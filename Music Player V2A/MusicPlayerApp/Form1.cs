using AxWMPLib;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using WMPLib;

namespace MusicPlayerApp
{
    /// <summary>
    /// This is the MusicPlayerApp class.
    /// </summary>
    public partial class MusicPlayerApp : Form
    {
        /// <summary>
        /// This declares the Windows Media Player Control
        /// </summary>
        private AxWMPLib.AxWindowsMediaPlayer Player; // Declare the WMP control
        /// <summary>
        /// 
        /// </summary>
        public MusicPlayerApp()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Create Global variables of String Type Array to save the
        /// titles of the Tracks and their paths
        /// </summary>
        String[] paths, files;

        public int False { get; private set; }
        public int currentSongIndex { get; private set; }
        bool playAllrunning = false;


        /// <summary>
        /// This button handler allows the user to select a group of 
        /// songs via the FileDialog box.  Multiselect is set on
        /// Array files is set to the names of the .mp3 files.
        /// Array paths is set to the URLs of the .mp3 files.
        /// The titles are displayed in the listbox.
        /// </summary>
        /// <param name="sender">This is the object that raised the event</param>
        /// <param name="e">This is a convention</param>
        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            //Code to select songs via FileDialog box

            OpenFileDialog ofd = new OpenFileDialog();

            //Code to allow user to select multiple files

            ofd.Multiselect = true;

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;  // Save the name of the track in files array
                paths = ofd.FileNames;      // Save the path of the track in paths array

                // Display the titles in the listbox

                for (int i = 0; i < files.Length; i++)
                {
                    listBoxSongs.Items.Add(files[i]);
                }
            }
        }
        /// <summary>
        /// This handler runs when a song title in the listbox is selected.
        /// It plays only that song and then play ends.
        /// </summary>
        /// <param name="sender">This is the object that raised the event</param>
        /// <param name="e">This is a convention</param>
        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Code to play a selected song

            if (!playAllrunning)
            {
                axWindowsMediaPlayerMusic.URL = paths[listBoxSongs.SelectedIndex];
            }

        }
        /// <summary>
        /// This button handler plays the next song in the list of songs
        /// as long as the end of the list has not been reached.
        /// If the last song is playing when the button is pressed, 
        /// then go back to the first song in the list.
        /// </summary>
        /// <param name="sender">This is the object that raised the event</param>
        /// <param name="e">This is a convention</param>
        private void btnPlayNextSong_Click(object sender, EventArgs e)
        {
            // Move to the next song as long as listBoxSongs.SelectedIndex < files.Length - 1
            // Go back to first song if you are on the last song

            if (listBoxSongs.SelectedIndex < files.Length - 1)
            {
                listBoxSongs.SelectedIndex = listBoxSongs.SelectedIndex + 1;
            }
            else
            {
                listBoxSongs.SelectedIndex = 0;
            }
            axWindowsMediaPlayerMusic.URL = paths[listBoxSongs.SelectedIndex];
        }
        /// <summary>
        /// This handler closes the app when you click the X in the 
        /// upper right corner of the window.
        /// </summary>
        /// <param name="sender">This is the object that raised the event</param>
        /// <param name="e">This is a convention</param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Code to close the app when you click on the X in UR corner

            this.Close();
        }
        /// <summary>
        /// This button handler handles the Play All button.
        /// First it creates a new, empty playlist,
        /// Then it adds each URL in array paths to the playlist.
        /// Finally, it sets the playlist to the current playlist
        /// for playback.
        /// </summary>
        /// <param name="sender">This is the object that raised the event</param>
        /// <param name="e">This is a convention</param>
        private void btnPlayAll_Click(object sender, EventArgs e)
        {
            playAllrunning = true;
            // Create a new empty playlist
            IWMPPlaylist playlist = axWindowsMediaPlayerMusic.playlistCollection.newPlaylist("MyDynamicPlaylist");

            // Add each media item from the array to the playlist
            foreach (string filePath in paths)
            {
                IWMPMedia mediaItem = axWindowsMediaPlayerMusic.newMedia(filePath);
                playlist.appendItem(mediaItem);
            }

            // Set the created playlist as the current playlist for playback
            axWindowsMediaPlayerMusic.currentPlaylist = playlist;
        }
        /// <summary>
        /// This handler highlights the current song
        /// It sets axWindowsMediaPlayerMusic controls to 
        /// stop playing the playlist and sets the index to 
        /// the first song.
        /// </summary>
        /// <param name="listBoxSongs">This is the list of songs in the listbox</param>
        /// <param name="e">This is a convention</param>
        /// 
        private void HighlightCurrentSong(ListBox listBoxSongs)
        {
            listBoxSongs.ClearSelected();
            listBoxSongs.SelectedIndex = currentSongIndex;
            listBoxSongs.TopIndex = currentSongIndex; // Scroll to the current song
        }
        /// <summary>
        /// This button handler handles the Stop button
        /// It sets axWindowsMediaPlayerMusic controls to 
        /// stop playing the playlist and sets the index to 
        /// the first song.
        /// </summary>
        /// <param name="sender">This is the object that raised the event</param>
        /// <param name="e">This is a convention</param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            // Handle end of playlist (e.g., stop)
            
            listBoxSongs.SelectedIndex = 0;
            axWindowsMediaPlayerMusic.Ctlcontrols.stop();
            playAllrunning = false;
        }
        /// <summary>
        /// Event handler for ListBoxSongs playlist selection change
        /// If the index is valid, then set the axWindowsMediaPlayerMusic.URL
        /// to the paths listBoxSongs selected index and set the 
        /// axWindowsMediaPlayerMusic controls to play the playlist
        /// </summary>
        /// <param name="sender">This is the object that raised the event</param>
        /// <param name="e">This is a convention</param>
        private void listBoxPlaylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxSongs.SelectedIndex != -1)
            {
                axWindowsMediaPlayerMusic.URL = paths[listBoxSongs.SelectedIndex];
                axWindowsMediaPlayerMusic.Ctlcontrols.play();
            }
        }

        /// <summary>
        /// Event handler for Clear List Box button to clear all items
        /// from the list box. This button can be used to reset the
        /// playlist to allow the user to select a new set of songs.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearListBox_Click(object sender, EventArgs e)
        {
            listBoxSongs.Items.Clear();
            axWindowsMediaPlayerMusic.Ctlcontrols.stop();
        }
        /// <summary>
        /// Event handler for Play Previous Song button to play the
        /// previous song in the list.  If the first song is currently
        /// playing, then go to the last song in the list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlayPrevSong_Click(object sender, EventArgs e)
        {
            if (listBoxSongs.SelectedIndex > 0)
            {
                listBoxSongs.SelectedIndex = listBoxSongs.SelectedIndex - 1;
            }
            else
            {
                listBoxSongs.SelectedIndex = files.Length - 1;
            }
        }
    }
}
