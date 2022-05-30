using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace week_14_praktikum_fix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable dtData = new DataTable();
        DataTable dtScore = new DataTable();
        DataTable dtGrid = new DataTable();
        DataTable dtWorst = new DataTable();
        int posisiSekarang = 0;

        public void IsiDataPemain(int Posisi)
        {
            labelTeamName.Text = dtData.Rows[Posisi][0].ToString();
            labelManager.Text = dtData.Rows[Posisi][1].ToString();
            labelStadium.Text = dtData.Rows[Posisi][2].ToString();
            string save = dtData.Rows[Posisi][3].ToString();
            dtGrid = new DataTable();
            dtWorst = new DataTable();
            posisiSekarang = Posisi;

            sqlQuery = "select concat(p.player_name, ' ', sum(dm.type = 'GO' OR dm.type = 'GP'), '(', sum(dm.type = 'GP'),')') from dmatch dm, player p where p.team_id = '" + dtData.Rows[Posisi]["team_id"] + "' and (dm.type = 'GO' OR dm.type = 'GP') and dm.player_id = p.player_id group by dm.player_id order by 1 desc;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtScore);
            labelTopScorer.Text = dtScore.Rows[Posisi][0].ToString();

            sqlQuery = "SELECT date_format(m.match_date, '%d/%c/%Y') as'match_date' , if(m.team_home = '" + save + "','HOME',if(team_away = '" + save + "','AWAY',0)) as 'Home/Away',if(m.team_home = '" + save + "',m.team_away,if(m.team_away = '" + save + "',m.team_home,0)) as 'lawan' ,concat(m.goal_home,'-',m.goal_away) as 'score' FROM `match` m where m.team_home = '" + save + "' or m.team_away = '" + save + "' order by m.match_date desc LIMIT 5 ;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtGrid);
            dataGridView_last5match.DataSource = dtGrid;

            sqlQuery = "SELECT p.player_name, SUM(if(d.`type`='CR',1,0)) , SUM(if(d.`type` = 'CY', 1, 0)) ,  sum(if(d.type = 'CY',1,0)) + sum(if(d.type = 'CR',3,0)) as 'poin'  from player p, dmatch d, team t where p.player_id = d.player_id and t.team_id = p.team_id and t.team_id='" + save + "' group by p.player_id order by poin desc;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtWorst);

            labelWorst.Text = dtWorst.Rows[0][0].ToString() + " ," + dtWorst.Rows[0][2].ToString() + " Yellow Card and " + dtWorst.Rows[0][1].ToString() + " Red Card";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            sqlQuery = "select t.team_name, concat(m.manager_name, ' (' ,n.nation, ')'), concat(t.home_stadium, ', ',  t.city, ' (',t.capacity,')') , team_id from team t, manager m, nationality n where t.manager_id = m.manager_id and n.nationality_id = m.nationality_id; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtData);

            DataTable dtMatch = new DataTable();
            sqlQuery = "select match_date from `match`";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtMatch);
            dataGridView_last5match.DataSource = dtMatch;

            IsiDataPemain(0);
        }

        private void buttonPrev2_Click(object sender, EventArgs e)
        {
            IsiDataPemain(0);
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (posisiSekarang > 0)
            {
                posisiSekarang--;
                IsiDataPemain(posisiSekarang);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Pertama");
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (posisiSekarang < dtData.Rows.Count - 1)
            {
                posisiSekarang++;
                IsiDataPemain(posisiSekarang);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Terakhir");
            }
        }

        private void buttonNext2_Click(object sender, EventArgs e)
        {
            IsiDataPemain(dtData.Rows.Count - 1);
        }
    }
}
