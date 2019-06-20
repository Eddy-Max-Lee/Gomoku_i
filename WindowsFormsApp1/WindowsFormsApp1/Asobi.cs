using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Asobi 
    {
        private board board = new board();

        private static PisType_Enum currentPlayer_Enum = PisType_Enum.BLACK;

        private PisType_Enum winner = PisType_Enum.NONE;
        public PisType_Enum Winner { get { return winner; } } //把winner以唯獨的方式傳給外面的人

        public  bool CanBePlaced(int x, int y)  //Method Board 的  CanBePlaced
        {
            return board.CanBePlaced(x, y);
        }

        public  pis PlaceAPis(int x, int y)  //Method Board 的  PlaceAPis
        {
          //  return board.PlaceAPis(x, y);
            pis piece = board.PlaceAPis(x, y, currentPlayer_Enum);

            if (piece != null)
            {

                if (currentPlayer_Enum == PisType_Enum.BLACK)  //交換使用者
                    currentPlayer_Enum = PisType_Enum.WHITE;
                else
                    currentPlayer_Enum = PisType_Enum.BLACK;

                return piece;
            }
            return null;
        }
        private void CheckWinner()
        {
            int centerX = board.LastPlacedNode.X;
            int centerY = board.LastPlacedNode.Y;

            //看最後一子附近有幾棵相同相連的棋子
            int count = 1;
            while(count<5)
            {
                int targetX = centerX + count;
                int targetY = centerY ;

                //檢查顏色是否相同
                if (targetX<0 || targetX>=board.NODE_COUNT ||
                    targetY < 0 || targetY >= board.NODE_COUNT ||
                   board.GetPisType(targetX, targetY) != currentPlayer_Enum)
                    break;


                count++;
            }
            //若看到五子連珠
            if (count == 5)
                winner = currentPlayer_Enum;


        }

    }
}