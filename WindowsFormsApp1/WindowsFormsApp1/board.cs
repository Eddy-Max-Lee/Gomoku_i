using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class board
    {
        public static readonly int NODE_COUNT = 9;

        private static readonly Point NO_MATCH_NODE = new Point(-1, -1);

        private static readonly int OFFSET = 75;
        private static readonly int NODE_RADIUS = 10;
        private static readonly int NODE_DISTANT = 75;

        private pis[,] pieces = new pis[NODE_COUNT, NODE_COUNT];
        private Point lastPlacedNode = NO_MATCH_NODE;
        public Point LastPlacedNode {            get { return lastPlacedNode; }        } //LastPlacedNode IS READONLY


 


        public PisType_Enum GetPisType(int nodeIdX, int nodeIdY ) //tell me what color is on the node
        {
            if (pieces[nodeIdX, nodeIdY] == null)
                return PisType_Enum.NONE;
            else
                return pieces[nodeIdX, nodeIdY].GetPisType();
        }




        public bool CanBePlaced(int x, int y)
        {
            //TODO: 找到最近ㄉ節點(node)
            Point nodeID = FindTheClosetNode(x, y);

            //TODO: 如果沒有，回傳FALSE
            if (nodeID == NO_MATCH_NODE)
                return false;

        
            //TODO:如果有, 檢查是否已有旗子
            if (pieces[nodeID.X, nodeID.Y] != null)//有棋子
                return false;
            return true;
        }

        private Point convertToFormPosition(Point nodeId)
        {
            Point formPosition = new Point();
            formPosition.X = nodeId.X * NODE_DISTANT + OFFSET;
            formPosition.Y = nodeId.Y * NODE_DISTANT + OFFSET;
            return formPosition;
        }


        public pis PlaceAPis(int x, int y, PisType_Enum type)
        {
            //TODO: 找到最近ㄉ節點(node)  
            Point nodeID = FindTheClosetNode(x, y);

            //TODO: 如果沒有，回傳FALSE
            if (nodeID == NO_MATCH_NODE)
                return null; //沒有物件

            //TODO:如果有, 檢查是否已有旗子
            if (pieces[nodeID.X, nodeID.Y] != null)//有棋子
                return null;
            //根據Type,產生棋子
            Point formPos = convertToFormPosition(nodeID);
            if (type == PisType_Enum.BLACK){
                pieces[nodeID.X, nodeID.Y]=new  Blackpis(formPos.X, formPos.Y);
               }else if (type == PisType_Enum.WHITE)
                pieces[nodeID.X, nodeID.Y] = new Whitepis(formPos.X, formPos.Y);

            //紀錄最後下子的位置
            lastPlacedNode= nodeID;

            return pieces[nodeID.X,nodeID.Y];


        }

        private Point FindTheClosetNode(int x, int y)  
        {
            int nodeIDX = FindTheClosetNode(x);
            if (nodeIDX == -1  || nodeIDX >= NODE_COUNT)  //為什麼不直接  if (x == -1  || x >= NODE_COUNT)
                return NO_MATCH_NODE; //橫上找不到

            int nodeIDY = FindTheClosetNode(y);
            if (nodeIDY == -1 || nodeIDY >= NODE_COUNT)
                return NO_MATCH_NODE; //束上找不到
            
            if (nodeIDX>8|| nodeIDY > 8)
                return NO_MATCH_NODE;

            return new Point(nodeIDX, nodeIDY); //找到惹回傳那個節點

        }

    
        private int FindTheClosetNode(int pos)  
        {
            if (pos < OFFSET - NODE_RADIUS)
                return -1;

            pos -= OFFSET;
            int quo = pos / NODE_DISTANT;
            int rmd = pos % NODE_DISTANT;

            if (rmd <= NODE_RADIUS) //靠近左(上)一位
                return quo;
            else if (rmd >= NODE_DISTANT - NODE_RADIUS)//靠近右(下)一位
                return quo + 1;
            else //沒有最近的節點
                return -1;

        }

       




PisType_Enum NodeToClean=new PisType_Enum();
   

  public void CleanBoard()
   {   
        Point clean = new Point(1,1);
            for( clean.X = 0; clean.X<=8; clean.X++){
                for( clean.Y =0; clean.Y<=8; clean.Y++){
                     if (NodeToClean!=PisType_Enum.NONE)
                        {
                        pieces[clean.X,clean.Y]=null;
                        }else
                    continue;
                    
                 }
              }

            
 }



    }
}
