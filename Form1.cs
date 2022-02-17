using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LogoKaresz
{
	public partial class Form1 : Form
	{
		/* Függvények */

		void EKG(double meret, int év)
		{

			if (év == 1)
			{
				Előre(meret);
			}
			else if (év > 1)
			{
				EKG(meret, év - 1);
				Balra(60);
				EKG(meret, év - 1);
				Jobbra(120);
				for (int i = 0; i < 2; i++)
				{
					EKG(meret, év - 1);

				}
				Balra(120);
				EKG(meret, év - 1);
				Jobbra(60);
				EKG(meret, év - 1);

			}
		}
		/* Függvények vége */
		void FELADAT()
		{
			/* Ezt indítja a START gomb! */
			Jobbra(90);
			EKG(25, 3);
			// Teleport(közép.X, közép.Y+150, észak);
		}
	}
}
