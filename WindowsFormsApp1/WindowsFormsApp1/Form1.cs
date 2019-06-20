using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    

    public partial class Form1 : Form
    {

        //private bool isBlack = true;
        private Asobi game = new Asobi();


        public Form1()
        {
            InitializeComponent();
       
           // this.Controls.Add(new Whitepis(50, 50));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

     

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            pis piece = game.PlaceAPis(e.X, e.Y);
            
            if (piece != null)
            {
                this.Controls.Add(piece);



                //每次增加一棋，就檢查有沒有人贏
                game.CheckWinner();
                if (game.Winner == PisType_Enum.BLACK)
                {
                    MessageBox.Show("黑色大成功");
                } else if(game.Winner == PisType_Enum.WHITE)
                {
                    MessageBox.Show("白色大成功");
                }
                
            }
        

        }

        private void Form1_MouseMove_1(object sender, MouseEventArgs e)
        {


                if (game.CanBePlaced(e.X,e.Y))
                {
                    this.Cursor = Cursors.Hand;
                }
                else
                {
                    this.Cursor = Cursors.Default;
                }
            
        }

        /*
        if (isBlack)
        {
           pis piece=board.PlaceAPis(e.X, e.Y, NextpisType_Enum);

            if(piece != null)
            {
                this.Controls.Add(piece);
                isBlack = false;
            }

            //this.Controls.Add(new Blackpis(e.X, e.Y));
            //isBlack = false;
        }
        else
        {
            pis piece = board.PlaceAPis(e.X, e.Y, NextpisType_Enum);

            if (piece != null)
            {
                this.Controls.Add(piece);
                isBlack = true;
            }



        }
        */

    }
   



}



