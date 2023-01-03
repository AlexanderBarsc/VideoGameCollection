using System.Data;
using System.Data.SQLite;
using Dapper;

namespace VideoGameCollection
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataAccess.LoadVideoGamesGameModels();

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            var videoGame = new VideoGameModel(NameTextBox.Text, PublisherTextBox.Text, PlatformTextBox.Text,
                Enum.Parse<Owned>(OwnedTextBox.Text), Convert.ToDouble(PriceTextBox.Text));

            DataAccess.AddVideoGame(videoGame);
        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected)
            {
                return;
            }

            NameTextBox.Text = e.Row.Cells[0].Value.ToString();
            PublisherTextBox.Text = e.Row.Cells[1].Value.ToString();
            PlatformTextBox.Text = e.Row.Cells[2].Value.ToString();
            OwnedTextBox.Text = e.Row.Cells[3].Value.ToString();
            PriceTextBox.Text = e.Row.Cells[4].Value.ToString();
            IdTextBox.Text = e.Row.Cells[5].Value.ToString();
        }

        private void ImportFromCsv_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            using (var reader = new StreamReader(openFileDialog1.FileName))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    var videoGame = new VideoGameModel(values[0], values[1], values[2],
                        Enum.Parse<Owned>(values[3]), Convert.ToDouble(values[4]));

                    DataAccess.AddVideoGame(videoGame);
                }
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DataAccess.DeleteVideoGame(NameTextBox.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var videoGame = new VideoGameModel(NameTextBox.Text, PublisherTextBox.Text, PlatformTextBox.Text,
                Enum.Parse<Owned>(OwnedTextBox.Text), Convert.ToDouble(PriceTextBox.Text), Convert.ToInt32(IdTextBox.Text));

            DataAccess.UpdateVideoGame(videoGame);
        }
    }
}