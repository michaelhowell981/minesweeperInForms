using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Data;




namespace Minesweeper
{
	public class GameBoard
	{
		int gridStartingX = 41;
		int gridStartingY = 41;
		Button[,] gridButton = new Button[41, 41];
		int buttonSize = 20;

		void CreateButtons (int rows , int columns)
		{
			for (int i = 1; i <= rows; i++)
			{
				for (int j = 1; j <= columns; j++)
				{
					gridButton[i, j] = new Button();
					gridButton[i, j].SetBounds(i * buttonSize + gridStartingX, i * buttonSize + gridStartingY, buttonSize, buttonSize);
					gridButton[i, j].Click += EventHandler(LeftClick);
					gridButton[i, j].MouseUp += MouseEventHandler(RightClick);
					
				}
			}
		}
	}
}
