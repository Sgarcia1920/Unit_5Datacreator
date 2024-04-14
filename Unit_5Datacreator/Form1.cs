using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Unit_5Datacreator
{
	public partial class Form1 : Form
	{
		string[] names;
		string[,] last_names;
		int[,,] dates;
		Random rand;
		public Form1()
		{
			InitializeComponent();
			names = new string[] { "Juan", "María", "Carlos", "Laura", "Pedro", "Ana", "Luis", "Elena", "Diego", "Sofía" };
			
			last_names = new string[,]
			{
			    { "González", "Ruiz" },
				{ "Martínez", "Vázquez" },
				{ "López", "Jiménez" },
				{ "Fernández", "Moreno" },
				{ "Pérez", "Hernández" },
				{ "Gómez", "Castillo" },
				{ "Díaz", "Navarro" },
				{ "Sánchez", "Silva" },
				{ "Torres", "Ramos" },
				{ "Romero", "Medina" }
			};

			dates = new int[,,]
			  {
			{ { 1980 }, { 5 }, { 15 } },
			{ { 1975 }, { 8 }, { 20 } },
			{ { 1992 }, { 3 }, { 10 } },
			{ { 1988 }, { 11 }, { 5 } },
			{ { 1995 }, { 2 }, { 25 } },
			{ { 1982 }, { 7 }, { 12 } },
			{ { 1987 }, { 9 }, { 30 } },
			{ { 1979 }, { 6 }, { 18 } },
			{ { 1990 }, { 4 }, { 8 } },
			{ { 1984 }, { 10 }, { 3 } }
			};

			rand = new Random();
		}

		private void btncreate_Click(object sender, EventArgs e)
		{
			
				txtNames.Text = names[rand.Next(names.Length)];
				txtpaternalsurname.Text = last_names[rand.Next(last_names.GetLength(0)), 0];
				txtmothersurname.Text = last_names[rand.Next(last_names.GetLength(0)), 1];
				int year = dates[rand.Next(dates.GetLength(0)), 0, 0];
				int month = dates[rand.Next(dates.GetLength(0)), 1, 0];
				int day = dates[rand.Next(dates.GetLength(0)), 2, 0];

				txtdateofbirth.Text = "" + year+ "/" + month + "/" + day;
			
			
		}

	}
	
}
