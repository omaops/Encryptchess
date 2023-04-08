namespace ChessAuth
{
    public partial class Form1 : Form
    {
        Pad p = new Pad();
        public Form1()
        {
            InitializeComponent();
            panel1.Enabled = false;
            submitMoveToolStripMenuItem.Visible = false;
            submitMoveToolStripMenuItem1.Visible = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            darkSqures(Color.LightBlue);
            corrd();
        }


        //Private code
        //File for enc Lock
        string lFileName;
        //string[] larrAllFiles; //used when Multiselect = true
        //File for dec Unlock
        string uFileName;
        //string[] uarrAllFiles; //used when Multiselect = true
        //Move List Password
        string brilliancy = "";
        //show corrd flag
        int showCorrd = 0;
        //Flosti Flag
        int frosti = 0;
        //Method to clean all
        public void cleanAll()
        {
            lFileName = "";
            uFileName = "";
            brilliancy = "";
            lockToolStripMenuItem.BackColor = SystemColors.Control;
            lockToolStripMenuItem.Text = "Lock";
            unlockToolStripMenuItem.BackColor = SystemColors.Control;
            unlockToolStripMenuItem.Text = "Unlock";
            submitMoveToolStripMenuItem.Visible = false;
            submitMoveToolStripMenuItem1.Visible = false;
            panel1.Enabled = false;
        }

        //Change the dark squre color
        public void darkSqures(Color darkSqureColor)
        {
            //Color darkSqureColor = Color.LightBlue;
            //First Rank
            a1.BackColor = darkSqureColor;
            c1.BackColor = darkSqureColor;
            e1.BackColor = darkSqureColor;
            g1.BackColor = darkSqureColor;
            //Second Rank
            b2.BackColor = darkSqureColor;
            d2.BackColor = darkSqureColor;
            f2.BackColor = darkSqureColor;
            h2.BackColor = darkSqureColor;
            //Third Rank
            a3.BackColor = darkSqureColor;
            c3.BackColor = darkSqureColor;
            e3.BackColor = darkSqureColor;
            g3.BackColor = darkSqureColor;
            //Forth Rank
            b4.BackColor = darkSqureColor;
            d4.BackColor = darkSqureColor;
            f4.BackColor = darkSqureColor;
            h4.BackColor = darkSqureColor;
            //Fifth Rank
            a5.BackColor = darkSqureColor;
            c5.BackColor = darkSqureColor;
            e5.BackColor = darkSqureColor;
            g5.BackColor = darkSqureColor;
            //Sixth Rank
            b6.BackColor = darkSqureColor;
            d6.BackColor = darkSqureColor;
            f6.BackColor = darkSqureColor;
            h6.BackColor = darkSqureColor;
            //Seventh Rank
            a7.BackColor = darkSqureColor;
            c7.BackColor = darkSqureColor;
            e7.BackColor = darkSqureColor;
            g7.BackColor = darkSqureColor;
            //Eight Rank
            b8.BackColor = darkSqureColor;
            d8.BackColor = darkSqureColor;
            f8.BackColor = darkSqureColor;
            h8.BackColor = darkSqureColor;


        }

        //Show or Hide Corrdinates
        public void corrd()
        {
            if (showCorrd == 1)
            {
                a1.Text = "a1";
                b1.Text = "b1";
                c1.Text = "c1";
                d1.Text = "d1";
                e1.Text = "e1";
                f1.Text = "f1";
                g1.Text = "g1";
                h1.Text = "h1";

                a2.Text = "a2";
                b2.Text = "b2";
                c2.Text = "c2";
                d2.Text = "d2";
                e2.Text = "e2";
                f2.Text = "f2";
                g2.Text = "g2";
                h2.Text = "h2";

                a3.Text = "a3";
                b3.Text = "b3";
                c3.Text = "c3";
                d3.Text = "d3";
                e3.Text = "e3";
                f3.Text = "f3";
                g3.Text = "g3";
                h3.Text = "h3";

                a4.Text = "a4";
                b4.Text = "b4";
                c4.Text = "c4";
                d4.Text = "d4";
                e4.Text = "e4";
                f4.Text = "f4";
                g4.Text = "g4";
                h4.Text = "h4";

                a5.Text = "a5";
                b5.Text = "b5";
                c5.Text = "c5";
                d5.Text = "d5";
                e5.Text = "e5";
                f5.Text = "f5";
                g5.Text = "g5";
                h5.Text = "h5";

                a6.Text = "a6";
                b6.Text = "b6";
                c6.Text = "c6";
                d6.Text = "d6";
                e6.Text = "e6";
                f6.Text = "f6";
                g6.Text = "g6";
                h6.Text = "h6";

                a7.Text = "a7";
                b7.Text = "b7";
                c7.Text = "c7";
                d7.Text = "d7";
                e7.Text = "e7";
                f7.Text = "f7";
                g7.Text = "g7";
                h7.Text = "h7";

                a8.Text = "a8";
                b8.Text = "b8";
                c8.Text = "c8";
                d8.Text = "d8";
                e8.Text = "e8";
                f8.Text = "f8";
                g8.Text = "g8";
                h8.Text = "h8";

            }
            else if (showCorrd == 0)
            {
                a1.Text = "";
                b1.Text = "";
                c1.Text = "";
                d1.Text = "";
                e1.Text = "";
                f1.Text = "";
                g1.Text = "";
                h1.Text = "";

                a2.Text = "";
                b2.Text = "";
                c2.Text = "";
                d2.Text = "";
                e2.Text = "";
                f2.Text = "";
                g2.Text = "";
                h2.Text = "";

                a3.Text = "";
                b3.Text = "";
                c3.Text = "";
                d3.Text = "";
                e3.Text = "";
                f3.Text = "";
                g3.Text = "";
                h3.Text = "";

                a4.Text = "";
                b4.Text = "";
                c4.Text = "";
                d4.Text = "";
                e4.Text = "";
                f4.Text = "";
                g4.Text = "";
                h4.Text = "";

                a5.Text = "";
                b5.Text = "";
                c5.Text = "";
                d5.Text = "";
                e5.Text = "";
                f5.Text = "";
                g5.Text = "";
                h5.Text = "";

                a6.Text = "";
                b6.Text = "";
                c6.Text = "";
                d6.Text = "";
                e6.Text = "";
                f6.Text = "";
                g6.Text = "";
                h6.Text = "";

                a7.Text = "";
                b7.Text = "";
                c7.Text = "";
                d7.Text = "";
                e7.Text = "";
                f7.Text = "";
                g7.Text = "";
                h7.Text = "";

                a8.Text = "";
                b8.Text = "";
                c8.Text = "";
                d8.Text = "";
                e8.Text = "";
                f8.Text = "";
                g8.Text = "";
                h8.Text = "";
            }
            else
            {
                a1.Text = "a1";
                b1.Text = "b1";
                c1.Text = "c1";
                d1.Text = "d1";
                e1.Text = "e1";
                f1.Text = "f1";
                g1.Text = "g1";
                h1.Text = "h1";

                a2.Text = "a2";
                b2.Text = "b2";
                c2.Text = "c2";
                d2.Text = "d2";
                e2.Text = "e2";
                f2.Text = "f2";
                g2.Text = "g2";
                h2.Text = "h2";

                a3.Text = "a3";
                b3.Text = "b3";
                c3.Text = "c3";
                d3.Text = "d3";
                e3.Text = "e3";
                f3.Text = "f3";
                g3.Text = "g3";
                h3.Text = "h3";

                a4.Text = "a4";
                b4.Text = "b4";
                c4.Text = "c4";
                d4.Text = "d4";
                e4.Text = "e4";
                f4.Text = "f4";
                g4.Text = "g4";
                h4.Text = "h4";

                a5.Text = "a5";
                b5.Text = "b5";
                c5.Text = "c5";
                d5.Text = "d5";
                e5.Text = "e5";
                f5.Text = "f5";
                g5.Text = "g5";
                h5.Text = "h5";

                a6.Text = "a6";
                b6.Text = "b6";
                c6.Text = "c6";
                d6.Text = "d6";
                e6.Text = "e6";
                f6.Text = "f6";
                g6.Text = "g6";
                h6.Text = "h6";

                a7.Text = "a7";
                b7.Text = "b7";
                c7.Text = "c7";
                d7.Text = "d7";
                e7.Text = "e7";
                f7.Text = "f7";
                g7.Text = "g7";
                h7.Text = "h7";

                a8.Text = "a8";
                b8.Text = "b8";
                c8.Text = "c8";
                d8.Text = "d8";
                e8.Text = "e8";
                f8.Text = "f8";
                g8.Text = "g8";
                h8.Text = "h8";
            }

            if (showCorrd == 1)
                showCorrd = 0;
            else
                showCorrd = 1;
        }



        //Private code end

        private void lockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                lFileName = choofdlog.FileName;
                //larrAllFiles = choofdlog.FileNames; //used when Multiselect = true
                if (lFileName != "")
                {
                    lockToolStripMenuItem.BackColor = SystemColors.ControlDark;
                    lockToolStripMenuItem.Text = "File Selected for Locking";
                    panel1.Enabled = true;
                    submitMoveToolStripMenuItem.Visible = true;
                }

            }
        }

        private void unlockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                uFileName = choofdlog.FileName;
                //uarrAllFiles = choofdlog.FileNames; //used when Multiselect = true
                if (uFileName != "")
                {
                    unlockToolStripMenuItem.BackColor = SystemColors.ControlDark;
                    unlockToolStripMenuItem.Text = "File Selected for Unlocking";
                    panel1.Enabled = true;
                    submitMoveToolStripMenuItem1.Visible = true;
                }
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cleanAll();
        }

        private void submitMoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (brilliancy == "")
            {
                MessageBox.Show("Please Enter Your Opening Moves");
                return;
            }

            p.FileEncrypt(lFileName, brilliancy);
            cleanAll();
        }

        private void submitMoveToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            string oFileName = uFileName.Remove(uFileName.Length - 4);
            string ext = Path.GetExtension(oFileName);
            oFileName = uFileName.Remove(uFileName.Length - 4) + "_unlocked" + ext;
            p.FileDecrypt(uFileName, oFileName, brilliancy);
            cleanAll();
        }

        private void a1_Click(object sender, EventArgs e)
        {
            brilliancy += "a1f83ft";
        }

        private void b1_Click(object sender, EventArgs e)
        {
            brilliancy += "b1ec1zu";
        }

        private void c1_Click(object sender, EventArgs e)
        {
            brilliancy += "c1tygtd";
        }

        private void d1_Click(object sender, EventArgs e)
        {
            brilliancy += "d13l40e";
        }

        private void e1_Click(object sender, EventArgs e)
        {
            brilliancy += "e1tmadj";
        }

        private void f1_Click(object sender, EventArgs e)
        {
            brilliancy += "f1iwvj6";
        }

        private void g1_Click(object sender, EventArgs e)
        {
            brilliancy += "g146pta";
        }

        private void h1_Click(object sender, EventArgs e)
        {
            brilliancy += "h1ta9vj";
        }

        private void a2_Click(object sender, EventArgs e)
        {
            brilliancy += "a2rvi7d";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            brilliancy += "b231qp9";
        }

        private void c2_Click(object sender, EventArgs e)
        {
            brilliancy += "c2o2bce";
        }

        private void d2_Click(object sender, EventArgs e)
        {
            brilliancy += "d2y6owr";
        }

        private void e2_Click(object sender, EventArgs e)
        {
            brilliancy += "e2kgr1q";
        }

        private void f2_Click(object sender, EventArgs e)
        {
            brilliancy += "f2n1pc8";
        }

        private void g2_Click(object sender, EventArgs e)
        {
            brilliancy += "g25vify";
        }

        private void h2_Click(object sender, EventArgs e)
        {
            brilliancy += "h2owyy0";
        }

        private void a3_Click(object sender, EventArgs e)
        {
            brilliancy += "a31k178";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            brilliancy += "b3eh7hd";
        }

        private void c3_Click(object sender, EventArgs e)
        {
            brilliancy += "c32of13";
        }

        private void d3_Click(object sender, EventArgs e)
        {
            brilliancy += "d3z2ik7";
        }

        private void e3_Click(object sender, EventArgs e)
        {
            brilliancy += "e3cvfnk";
        }

        private void f3_Click(object sender, EventArgs e)
        {
            brilliancy += "f3xkvxn";
        }

        private void g3_Click(object sender, EventArgs e)
        {
            brilliancy += "g37l4v3";
        }

        private void h3_Click(object sender, EventArgs e)
        {
            brilliancy += "h3koua6";
        }

        private void a4_Click(object sender, EventArgs e)
        {
            brilliancy += "a4sc8nh";
        }

        private void b4_Click(object sender, EventArgs e)
        {
            brilliancy += "b4n4rdo";
        }

        private void c4_Click(object sender, EventArgs e)
        {
            brilliancy += "c478620";
        }

        private void d4_Click(object sender, EventArgs e)
        {
            brilliancy += "d4qvory";
        }

        private void e4_Click(object sender, EventArgs e)
        {
            brilliancy += "e45wwii";
        }

        private void f4_Click(object sender, EventArgs e)
        {
            brilliancy += "f49hd0h";
        }

        private void g4_Click(object sender, EventArgs e)
        {
            brilliancy += "g4tgwm7";
        }

        private void h4_Click(object sender, EventArgs e)
        {
            brilliancy += "h4lbhae";
        }

        private void a5_Click(object sender, EventArgs e)
        {
            brilliancy += "a5xy4z8";
        }

        private void b5_Click(object sender, EventArgs e)
        {
            brilliancy += "b5qcpco";
        }

        private void c5_Click(object sender, EventArgs e)
        {
            brilliancy += "c57ynv4";
        }

        private void d5_Click(object sender, EventArgs e)
        {
            brilliancy += "d51pzdd";
        }

        private void e5_Click(object sender, EventArgs e)
        {
            brilliancy += "e5lgza2";
        }

        private void f5_Click(object sender, EventArgs e)
        {
            brilliancy += "f5h2t5y";
        }

        private void g5_Click(object sender, EventArgs e)
        {
            brilliancy += "g5eruy8";
        }

        private void h5_Click(object sender, EventArgs e)
        {
            brilliancy += "h59nqew";
        }

        private void a6_Click(object sender, EventArgs e)
        {
            brilliancy += "a6zdvnd";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            brilliancy += "b6lq0zz";
        }

        private void c6_Click(object sender, EventArgs e)
        {
            brilliancy += "c69nwxe";
        }

        private void d6_Click(object sender, EventArgs e)
        {
            brilliancy += "d6668pw";
        }

        private void e6_Click(object sender, EventArgs e)
        {
            brilliancy += "e609hdk";
        }

        private void f6_Click(object sender, EventArgs e)
        {
            brilliancy += "f6dcx4x";
        }

        private void g6_Click(object sender, EventArgs e)
        {
            brilliancy += "g6rjdip";
        }

        private void h6_Click(object sender, EventArgs e)
        {
            brilliancy += "h69ss0g";
        }

        private void a7_Click(object sender, EventArgs e)
        {
            brilliancy += "a7spibi";
        }

        private void b7_Click(object sender, EventArgs e)
        {
            brilliancy += "b7rokka";
        }

        private void c7_Click(object sender, EventArgs e)
        {
            brilliancy += "c7oz8i1";
        }

        private void d7_Click(object sender, EventArgs e)
        {
            brilliancy += "d7mu1qa";
        }

        private void e7_Click(object sender, EventArgs e)
        {
            brilliancy += "e73ekps";
        }

        private void f7_Click(object sender, EventArgs e)
        {
            brilliancy += "f7x8pvu";
        }

        private void g7_Click(object sender, EventArgs e)
        {
            brilliancy += "g7hpen5";
        }

        private void h7_Click(object sender, EventArgs e)
        {
            brilliancy += "h74z6q5";
        }

        private void a8_Click(object sender, EventArgs e)
        {
            brilliancy += "a8gndfo";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            brilliancy += "b8x1evr";
        }

        private void c8_Click(object sender, EventArgs e)
        {
            brilliancy += "c8cajyb";
        }

        private void d8_Click(object sender, EventArgs e)
        {
            brilliancy += "d84j2mv";
        }

        private void e8_Click(object sender, EventArgs e)
        {
            brilliancy += "e821t67";
        }

        private void f8_Click(object sender, EventArgs e)
        {
            brilliancy += "f8z2gg0";
        }

        private void g8_Click(object sender, EventArgs e)
        {
            brilliancy += "g8wf4v3";
        }

        private void h8_Click(object sender, EventArgs e)
        {
            brilliancy += "h8124zu";
        }

        private void showHideCordinatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            corrd();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frosti == 7)
                MessageBox.Show("LYFF²", "Theo");
            else
                MessageBox.Show("Developer: Tinbite Solomon \n\nUses AES for Encryption (You know the saying 'Never roll your own crypto')", "About");

            frosti++;

        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Simple, it just allows you to encrypt something based on a chess move patern you can remember.\nGood for encrypting your chessbase or other prep files. \nYou have to atleast click on a squre to start encrypting. \nNot recommended for players with EGO ... sorry I meant ELOs lessthan Magnus. ", "Manual");
        }
    }
}