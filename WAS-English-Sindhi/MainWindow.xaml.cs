using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Speech.Synthesis;
using System.IO;
using LiteDB;


namespace WAS_English_Sindhi
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>


    public partial class MainWindow : Window
    {
        public class wordStructure
        {
            public ObjectId id { get; set; }
            public string word { get; set; }
            public Dictionary<string, string[]> word_data { get; set; }
        }

        public class wordsL
        {

            public ObjectId id { get; set; }
            public string word { get; set; }
            
        }

        /*
         * Dictionary contains mapping from tab_name to index in tabsList and tabsView
         */
        public Dictionary<string, int> indexToDic;
        public TabItem[] tabsList;
        public ListView[] tabsView;
        public string currentWord;
        public Dictionary<string, string[]> currentData;
        public SpeechSynthesizer speechObj = new SpeechSynthesizer();
        
        public LiteCollection<wordStructure> db_col;
        public LiteDatabase db;


        public void setWord()
        {
            dicTab.Items.Clear();
            

            int currentIndex;
            ListView currentList;
            TabItem currentTab;
             
           
            foreach (KeyValuePair<string, string[]> currentItem in currentData)
            {

                currentIndex = indexToDic[currentItem.Key];
                currentTab = tabsList[currentIndex];
                currentList = tabsView[currentIndex];


                currentList.Items.Clear();
             
               

                    foreach (string word in currentItem.Value)
                    {
                        currentList.Items.Add(word);

                    }
                



                dicTab.Items.Add(currentTab);
                
            }
            

            wordText.Content = currentWord;

            dicTab.SelectedIndex = 0;
        }

        

        public void initDb(){

            db = new LiteDatabase("en_sin.db");
            db_col = db.GetCollection<wordStructure>("words");

            var wcol = db.GetCollection<wordsL>("words_list");

            var temp = wcol.FindAll().ToArray();
            var data_length = temp.Length;
            //words_list = new string[data_length];
            var current_index = 0;
          

            while (current_index < data_length)
            {

                //indexBox.Items.Add(words_list[current_index] = temp[current_index].word );
                //current_index++;
                indexBox.Items.Add(temp[current_index++].word);
               

            }

        }

        public void StartFunc()
        {
            /*
             Initiliaze My Data
             */

            initDb();



            indexToDic = new Dictionary<string, int>();
            tabsList = new TabItem[4];
            tabsView = new ListView[4];


            tabsList[0] = en_sin_tab;
            tabsView[0] = en_sin_list;
            indexToDic.Add("en_sin", 0);



            tabsList[1] = cbank_tab;
            tabsView[1] = cbank_list;
            indexToDic.Add("cb", 1);



            tabsList[2] = geog_sin_tab;
            tabsView[2] = geog_sin_list;
            indexToDic.Add("geog", 2);
            dicTab.Items.RemoveAt(1);


            tabsList[3] = off_term_tab;
            tabsView[3] = off_term_list;
            indexToDic.Add("off_term", 3);

            currentWord = "A";
           
            currentData = new Dictionary<string, string[]> { };
            currentData.Add("en_sin", new string[]{ "هڪڙو",
                "ڪو",
                "انگريزي آئيويٽا جو پهريون اکر" });


            setWord();
            
            
            //Icon = topIcon.Source;


        }

        public void SpeakCurrent()
        {
           
            speechObj.Speak(currentWord);
            
       

        }

        public MainWindow()
        {
            InitializeComponent();

            StartFunc();

            /*
            en_sin_list.Items.Add("Waryam");

            dicTab.Items.RemoveAt(0);
            dicTab.Items.Add(en_sin_tab);
            //*/





        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SpeakCurrent();
           
        
        }

        public void getWordData(string w)
        {

            var currentD = db_col.FindOne(x => x.word == w);

            currentWord = w;
            currentData = currentD.word_data;

            setWord();
 

        }

        public void getWord(string w = null)
        {
            

            if (w == null)
            {
                string temp = searchBox.Text.ToLower();
                temp = temp[0].ToString().ToUpper() + temp.Substring(1);
               

                if (indexBox.Items.Contains(temp))
                {
                    getWordData(temp);
                }
                else
                {
                MessageBox.Show("No Such Word In Dictionary", "Word Not Found", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                getWordData(w);
            }


        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            getWord();
        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.Key.ToString() == "Return")
            {
                getWord();
            }
            

        }

        private void Window_Closed(object sender, EventArgs e)
        {

        }

        private void indexBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string changedWord = (string) e.AddedItems[0];

            getWord(changedWord);

            
        }
    }

}
