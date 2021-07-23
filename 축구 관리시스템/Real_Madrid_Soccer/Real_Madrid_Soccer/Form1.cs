using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Madrid_Soccer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Courtois_Click(object sender, EventArgs e)
        {
            gunaPictureBox_pp.Image = Courtois.Image;
        }

        private void Marcelo_Click(object sender, EventArgs e)
        {
            gunaPictureBox_pp.Image = Marcelo.Image;
        }

        private void Varane_Click(object sender, EventArgs e)
        {
            gunaPictureBox_pp.Image = Varane.Image;
        }

        private void Ramos_Click(object sender, EventArgs e)
        {
            gunaPictureBox_pp.Image = Militão.Image;
        }

        private void Carvajal_Click(object sender, EventArgs e)
        {
            gunaPictureBox_pp.Image = Carvajal.Image;
        }

        private void Casemiro_Click(object sender, EventArgs e)
        {
            gunaPictureBox_pp.Image = Casemiro.Image;
        }

        private void Kroos_Click(object sender, EventArgs e)
        {
            gunaPictureBox_pp.Image = Kroos.Image;
        }

        private void Modric_Click(object sender, EventArgs e)
        {
            gunaPictureBox_pp.Image = Modric.Image;
        }

        private void Hazard_Click(object sender, EventArgs e)
        {
            gunaPictureBox_pp.Image = Hazard.Image;
        }

        private void Benzema_Click(object sender, EventArgs e)
        {
            gunaPictureBox_pp.Image = Benzema.Image;
        }

        private void Bale_Click(object sender, EventArgs e)
        {
            gunaPictureBox_pp.Image = Bale.Image;
        }

        private void Alaba_Click(object sender, EventArgs e)
        {
            gunaPictureBox_pp.Image = Alaba.Image;
        }

        private void Vazquez_Click(object sender, EventArgs e)
        {
            gunaPictureBox_pp.Image = Vazquez.Image;
        }

        private void Mendy_Click(object sender, EventArgs e)
        {
            gunaPictureBox_pp.Image = Mendy.Image;
        }

        private void Isco_Click(object sender, EventArgs e)
        {
            gunaPictureBox_pp.Image = Isco.Image;
        }

        private void Valverde_Click(object sender, EventArgs e)
        {
            gunaPictureBox_pp.Image = Valverde.Image;
        }

        private void gunaButton1_MouseEnter(object sender, EventArgs e)
        {
            gunaPanel_pro.Location = new Point(gunaButton1.Location.X, gunaButton1.Location.Y);
            gunaPictureBox_show.Image = Courtois.Image;
            Courtois.Text = "1";
            gunaPanel_pro.Visible = true;
        }

        private void gunaButton1_MouseLeave(object sender, EventArgs e)
        {
            gunaPanel_pro.Visible = false;
        }

        private void gunaButton4_MouseEnter(object sender, EventArgs e)
        {
            gunaPanel_pro2.Location = new Point(gunaButton4.Location.X, gunaButton4.Location.Y);
            gunaPictureBox_show2.Image = Marcelo.Image;
            Marcelo.Text = "12";
            gunaPanel_pro2.Visible = true;
        }

        private void gunaButton4_MouseLeave(object sender, EventArgs e)
        {
            gunaPanel_pro2.Visible = false;
        }

        private void gunaButton2_MouseEnter(object sender, EventArgs e)
        {
            gunaPanel_pro3.Location = new Point(gunaButton2.Location.X, gunaButton2.Location.Y);
            gunaPictureBox_show3.Image = Varane.Image;
            Marcelo.Text = "5";
            gunaPanel_pro3.Visible = true;
        }

        private void gunaButton2_MouseLeave(object sender, EventArgs e)
        {
            gunaPanel_pro3.Visible = false;
        }

        private void gunaButton3_MouseEnter(object sender, EventArgs e)
        {
            gunaPanel_pro4.Location = new Point(gunaButton3.Location.X, gunaButton3.Location.Y);
            gunaPictureBox_show4.Image = Militão.Image;
            Militão.Text = "3";
            gunaPanel_pro4.Visible = true;
        }

        private void gunaButton3_MouseLeave(object sender, EventArgs e)
        {
            gunaPanel_pro4.Visible = false;
        }

        private void gunaButton5_MouseEnter(object sender, EventArgs e)
        {
            gunaPanel_pro5.Location = new Point(gunaButton5.Location.X, gunaButton5.Location.Y);
            gunaPictureBox_show5.Image = Carvajal.Image;
            Carvajal.Text = "2";
            gunaPanel_pro5.Visible = true;
        }

        private void gunaButton5_MouseLeave(object sender, EventArgs e)
        {
            gunaPanel_pro5.Visible = false;
        }

        private void gunaButton6_MouseEnter(object sender, EventArgs e)
        {
            gunaPanel_pro6.Location = new Point(gunaButton6.Location.X, gunaButton6.Location.Y);
            gunaPictureBox_show6.Image = Casemiro.Image;
            Casemiro.Text = "14";
            gunaPanel_pro6.Visible = true;
        }

        private void gunaButton6_MouseLeave(object sender, EventArgs e)
        {
            gunaPanel_pro6.Visible = false;
        }

        private void gunaButton8_MouseEnter(object sender, EventArgs e)
        {
            gunaPanel_pro7.Location = new Point(gunaButton8.Location.X, gunaButton8.Location.Y);
            gunaPictureBox_show7.Image = Kroos.Image;
            Kroos.Text = "8";
            gunaPanel_pro7.Visible = true;
        }

        private void gunaButton8_MouseLeave(object sender, EventArgs e)
        {
            gunaPanel_pro7.Visible = false;
        }

        private void gunaButton7_MouseEnter(object sender, EventArgs e)
        {
            gunaPanel_pro8.Location = new Point(gunaButton7.Location.X, gunaButton7.Location.Y);
            gunaPictureBox_show8.Image = Modric.Image;
            Modric.Text = "10";
            gunaPanel_pro8.Visible = true;

        }

        private void gunaButton7_MouseLeave(object sender, EventArgs e)
        {
            gunaPanel_pro8.Visible = false;
        }

        private void gunaButton10_MouseEnter(object sender, EventArgs e)
        {
            gunaPanel_pro9.Location = new Point(gunaButton10.Location.X, gunaButton10.Location.Y);
            gunaPictureBox_show9.Image = Hazard.Image;
            Hazard.Text = "7";
            gunaPanel_pro9.Visible = true;
        }

        private void gunaButton10_MouseLeave(object sender, EventArgs e)
        {
            gunaPanel_pro9.Visible = false;
        }

        private void gunaButton9_MouseEnter(object sender, EventArgs e)
        {
            gunaPanel_pro10.Location = new Point(gunaButton9.Location.X, gunaButton9.Location.Y);
            gunaPictureBox_show10.Image = Benzema.Image;
            Benzema.Text = "10";
            gunaPanel_pro10.Visible = true;
        }

        private void gunaButton9_MouseLeave(object sender, EventArgs e)
        {
            gunaPanel_pro10.Visible = false;
        }

        private void gunaButton11_MouseEnter(object sender, EventArgs e)
        {
            gunaPanel_pro11.Location = new Point(gunaButton11.Location.X, gunaButton11.Location.Y);
            gunaPictureBox_show11.Image = Bale.Image;
            Bale.Text = "11";
            gunaPanel_pro11.Visible = true;
        }

        private void gunaButton11_MouseLeave(object sender, EventArgs e)
        {
            gunaPanel_pro11.Visible = false;
        }

        // 축구 리그 & 축구 대회 & 축구게임& 축구 중계
        private void Champions_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.uefa.com/uefachampionsleague/");  // 챔피언스리그 대회
        }

        private void Uropa_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.uefa.com/uefaeuropaleague/"); // 유로파리그 대회
        }

        private void LaLiga_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.laliga.com/en-GB/laliga-santander/clubs"); // 프리메라리가
        }

        private void SpotvNow_Click(object sender, EventArgs e) // SPOTV NOW 축구 시청
        {
            System.Diagnostics.Process.Start("https://www.spotvnow.co.kr/intro");
        }

        private void SuperCup_Click(object sender, EventArgs e) // 슈퍼컵 대회
        {
            System.Diagnostics.Process.Start("https://www.uefa.com/uefasupercup/news/");
        }

        private void Copa_Click(object sender, EventArgs e) // 코파컵 대회
        {
            System.Diagnostics.Process.Start("https://www.laliga.com/en-ES/videos?competitionslug=copa-del-rey");
        }

        private void FIFA4_Click(object sender, EventArgs e) //  피파온라인 4 축구게임
        {
            System.Diagnostics.Process.Start("http://fifaonline4.nexon.com/main/index");
        }

        private void EA_Click(object sender, EventArgs e) // EA 2022 축구게임
        {
            System.Diagnostics.Process.Start("https://www.ea.com/games/fifa/fifa-22");
        }

        private void konami_Click(object sender, EventArgs e) // 위닝일레븐  2022 축구게임
        {
            System.Diagnostics.Process.Start("https://www.konami.com/wepes/2021/as/ko/ps4/");
        }

        private void Ranking_Click(object sender, EventArgs e) // 팀 순위 
        {
            System.Diagnostics.Process.Start("https://sports.news.naver.com/wfootball/record/index?category=primera&tab=team");
        }

        private void Shop_Click(object sender, EventArgs e) // 레알마드리드 굿즈 샵
        {
            System.Diagnostics.Process.Start("https://shop.realmadrid.com/collections/fanworld-gifts?lang=en&utm_campaign=enlaces-tienda&utm_source=web&utm_medium=links-tienda&utm_content=regalos");
        }

        // 선수 경력 및 수상 및 커리어

        private void GK_Click(object sender, EventArgs e) // 골키퍼 쿠르투아 경력 및 수상 및 커리어
        {
            System.Diagnostics.Process.Start("https://www.realmadrid.com/en/football/squad/thibaut-courtois");
        }

        private void LB_Click(object sender, EventArgs e) // 왼쪽 수비수 마르셀루 경력 및 수상 및 커리어
        {
            System.Diagnostics.Process.Start("https://www.realmadrid.com/en/football/squad/marcelo-vieira-da-silva");
        }

        private void LCB_Click(object sender, EventArgs e) // 중앙 수비수 바란 경력  및 수상 및 커리어
        {
            System.Diagnostics.Process.Start("https://www.realmadrid.com/en/football/squad/raphael-varane");
        }

        private void RCB_Click(object sender, EventArgs e) // 중앙 수비수 에데르 밀리탕 경력 및 수상 및 커리어
        {
            System.Diagnostics.Process.Start("https://www.realmadrid.com/en/football/squad/eder-gabriel-militao");
        }

        private void RB_Click(object sender, EventArgs e) // 오른쪽 수비수 카르바할 경력 및 수상 및 커리어
        {
            System.Diagnostics.Process.Start("https://www.realmadrid.com/en/football/squad/daniel-carvajal-ramos");
        }

        private void CDM_Click(object sender, EventArgs e) // 중앙 수비 미드필더 카제미루 경력 및 수상 및 커리어
        {
            System.Diagnostics.Process.Start("https://www.realmadrid.com/en/football/squad/carlos-henrique-casemiro");
        }

        private void LCM_Click(object sender, EventArgs e) // 왼쪽 미드필더 토니 크로스 경력 및 수상 및 커리어
        {
            System.Diagnostics.Process.Start("https://www.realmadrid.com/en/football/squad/toni-kroos");
        }

        private void RCM_Click(object sender, EventArgs e) // 오른쪽 미드필더 루카 모드리치 경력 및 수상 및 커리어
        {
            System.Diagnostics.Process.Start("https://www.realmadrid.com/en/football/squad/luka-modric");
        }

        private void LW_Click(object sender, EventArgs e) // 왼쪽 공격수 아자르 경력 및 수상 및 커리어
        {
            System.Diagnostics.Process.Start("https://www.realmadrid.com/en/football/squad/eden-hazard");
        }

        private void ST_Click(object sender, EventArgs e) // 공격수 벤제마 경력 및 수상 및 커리어
        {
            System.Diagnostics.Process.Start("https://www.realmadrid.com/en/football/squad/karim-benzema");
        }

        private void RW_Click(object sender, EventArgs e) // 오른쪽 공격수 베일 경력 및 수상 및 커리어
        {
            System.Diagnostics.Process.Start("https://www.realmadrid.com/en/football/squad/gareth-bale");
        }

        private void Bench_Click(object sender, EventArgs e) // 후보 선수 데이비드 알라바 경력 및 수상 및 커리어
        {
            System.Diagnostics.Process.Start("https://www.realmadrid.com/en/football/squad/david-alaba");
        }

        private void Bench2_Click(object sender, EventArgs e) // 후보선수 루카스 바스케스 경력 및 수상 및 커리어
        {
            System.Diagnostics.Process.Start("https://www.realmadrid.com/en/football/squad/lucas-vazquez-iglesias-");
        }

        private void Bench3_Click(object sender, EventArgs e) // 후보선수 페를랑 멘디 경력 및 수상 및 커리어
        {
            System.Diagnostics.Process.Start("https://www.realmadrid.com/en/football/squad/ferland-mendy");
        }

        private void Bench4_Click(object sender, EventArgs e) // 후보선수 이스코 경력 및 수상 및 커리어
        {
            System.Diagnostics.Process.Start("https://www.realmadrid.com/en/football/squad/francisco-roman--alarcon");
        }

        private void Bench5_Click(object sender, EventArgs e) // 후보선수 발베르데 경력 및 수상 및 커리어
        {
            System.Diagnostics.Process.Start("https://www.realmadrid.com/en/football/squad/federico-santiago-valverde-dipetta");
        }

        private void Match_Click(object sender, EventArgs e) // 
        {
            System.Diagnostics.Process.Start("https://www.laliga.com/laliga-santander/calendario");
        }
    }
}

