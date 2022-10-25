using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_Star_
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			starLabel.Text = string.Empty;
		}

		private void inputbtn_Click(object sender, EventArgs e)
		{
			int rows=0;
			try
			{
				 rows = Getrows();

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			string result = GenerateStar(rows); //rows會錯

			//放入TextBox
			DisplayStar(result);
		}

		private void inputbtn2_Click(object sender, EventArgs e)
		{
			int rows = 0;
			try
			{
				rows = Getrows();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			string result = GenerateLeftStar(rows); //rows會錯

			//放入TextBox
			DisplayStar(result);
		}

		private void inputbtn3_Click(object sender, EventArgs e)
		{
			int rows = 0;
			try
			{
				rows = Getrows();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			string result = GenerateSameStar(rows); //rows會錯

			//放入TextBox
			DisplayStar(result);
		}

		private int Getrows()
		{
			bool isNumber = int.TryParse(rowText.Text, out int rows);
			if (isNumber == false)
			{
				throw new Exception("請輸入列數");
			}
			if(rows <= 0)
			{
				throw new Exception("請輸入正整數");
			}
			if (rows > 10)
			{
				throw new Exception("請輸入1~10的數字");
			}
			return rows;
		}

		private string GenerateStar(int rows)
		{
			string result = string.Empty;
			for (int i = 1; i <= rows; i++)
			{
				result += new string('*', i) + "\r\n"; //+=忘記了
			}
			return result; //記得要return
		}
		private string DisplayStar(string star)
		{
			starText.Text = star;
			starLabel.Text = star;
			return star;
		}
		private string GenerateLeftStar(int rows)
		{
			string result = string.Empty;
			int star = 0;
			string[] empty = { string.Empty, "1" };
			for (int i = rows; 0 < i; i--)
			{
				star++;
				result += new string(' ', i) + new string(' ', i) + new string('*', star) + "\r\n";
			}
			return result;

		}
		private string GenerateSameStar(int rows)
		{
			string result = string.Empty;
			int star = 1;
			for (int i = rows - 1; 0 <= i; i--)
			{
				result += new string(' ', i) + new string(' ', i) + new string('*', star) + "\r\n";
				star += 2;
			}
			return result;
		}

		private void rowlbl_Click(object sender, EventArgs e)
		{

		}
		//取列數
		//int? rows = GetRows(); //若要顯示null要+?
		//	if (rows.HasValue == false) //null
		//	{
		//		MessageBox.Show("請輸入列數");
		//		return;
		//	}

		//	//判斷>0
		//	if(rows.Value <= 0)
		//	{
		//		MessageBox.Show("請輸入正整數");
		//		return ;
		//	}
		//private int? GetRows() //若要顯示null要+? 要回傳都要有東西
		//{
		//	bool isInt = int.TryParse(rowText.Text, out int rows);
		//	if (isInt) { return rows; }
		//	else { return null; }
		//}
	}
}
