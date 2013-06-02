/*
 * Created by SharpDevelop.
 * User: Leon
 * Date: 02/06/2013
 * Time: 08:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;

namespace vzMapper
{
	/// <summary>
	/// Description of OptionsForm.
	/// </summary>
	public partial class OptionsForm : Form
	{
		public OptionsForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			

			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void OptionsFormLoad(object sender, EventArgs e)
		{
			worldImageTopLeftTbx.Text = MainForm.worldImageTopLeftCornerX.ToString() + "," + MainForm.worldImageTopLeftCornerY.ToString();
			worldImageWidthTbx.Text = MainForm.worldImageWidth.ToString();
			worldImageHeightTbx.Text = MainForm.worldImageHeight.ToString();
			leftArrowPosTbx.Text = MainForm.leftArrowPosX.ToString() + "," + MainForm.leftArrowPosY.ToString();
			upArrowPosTbx.Text = MainForm.upArrowPosX.ToString() + "," + MainForm.upArrowPosY.ToString();
			downArrowPosTbx.Text = MainForm.downArrowPosX.ToString() + "," + MainForm.downArrowPosY.ToString();
			rightArrowPosTbx.Text = MainForm.rightArrowPosX.ToString() + "," + MainForm.rightArrowPosY.ToString();
		}
		
		void OptionsFormFormClosing(object sender, FormClosingEventArgs e)
		{
			
			
			// Store checkbox options in global variables:
			MainForm.worldImageTopLeftCornerX = Convert.ToInt32(worldImageTopLeftTbx.Text.Split(',')[0]);
			MainForm.worldImageTopLeftCornerY = Convert.ToInt32(worldImageTopLeftTbx.Text.Split(',')[1]);
			MainForm.worldImageWidth = Convert.ToInt32(worldImageWidthTbx.Text);
			MainForm.worldImageHeight = Convert.ToInt32(worldImageHeightTbx.Text);
			MainForm.leftArrowPosX = Convert.ToInt32(leftArrowPosTbx.Text.Split(',')[0]);
			MainForm.leftArrowPosY = Convert.ToInt32(leftArrowPosTbx.Text.Split(',')[1]);
			MainForm.upArrowPosX = Convert.ToInt32(upArrowPosTbx.Text.Split(',')[0]);
			MainForm.upArrowPosY = Convert.ToInt32(upArrowPosTbx.Text.Split(',')[1]);
			MainForm.downArrowPosX = Convert.ToInt32(downArrowPosTbx.Text.Split(',')[0]);
			MainForm.downArrowPosY = Convert.ToInt32(downArrowPosTbx.Text.Split(',')[1]);
			MainForm.rightArrowPosX = Convert.ToInt32(rightArrowPosTbx.Text.Split(',')[0]);
			MainForm.rightArrowPosY = Convert.ToInt32(rightArrowPosTbx.Text.Split(',')[1]);



			// Now store those options in the app.config file:
			Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

			config.AppSettings.Settings.Remove("worldImageTopLeftCornerX");
			config.AppSettings.Settings.Add("worldImageTopLeftCornerX", MainForm.worldImageTopLeftCornerX.ToString() );
			config.AppSettings.Settings.Remove("worldImageTopLeftCornerY");
			config.AppSettings.Settings.Add("worldImageTopLeftCornerY", MainForm.worldImageTopLeftCornerY.ToString() );
			config.AppSettings.Settings.Remove("worldImageWidth");
			config.AppSettings.Settings.Add("worldImageWidth", MainForm.worldImageWidth.ToString() );
			config.AppSettings.Settings.Remove("worldImageHeight");
			config.AppSettings.Settings.Add("worldImageHeight", MainForm.worldImageHeight.ToString() );
			config.AppSettings.Settings.Remove("leftArrowPosX");
			config.AppSettings.Settings.Add("leftArrowPosX", MainForm.leftArrowPosX.ToString() );
			config.AppSettings.Settings.Remove("leftArrowPosY");
			config.AppSettings.Settings.Add("leftArrowPosY", MainForm.leftArrowPosY.ToString() );
			config.AppSettings.Settings.Remove("upArrowPosX");
			config.AppSettings.Settings.Add("upArrowPosX", MainForm.upArrowPosX.ToString() );
			config.AppSettings.Settings.Remove("upArrowPosY");
			config.AppSettings.Settings.Add("upArrowPosY", MainForm.upArrowPosY.ToString() );
			config.AppSettings.Settings.Remove("downArrowPosX");
			config.AppSettings.Settings.Add("downArrowPosX", MainForm.downArrowPosX.ToString() );
			config.AppSettings.Settings.Remove("downArrowPosY");
			config.AppSettings.Settings.Add("downArrowPosY", MainForm.downArrowPosY.ToString() );
			config.AppSettings.Settings.Remove("rightArrowPosX");
			config.AppSettings.Settings.Add("rightArrowPosX", MainForm.rightArrowPosX.ToString() );
			config.AppSettings.Settings.Remove("rightArrowPosY");
			config.AppSettings.Settings.Add("rightArrowPosY", MainForm.rightArrowPosY.ToString() );

			config.Save(ConfigurationSaveMode.Modified);

		}
		
		void OkBtnClick(object sender, EventArgs e)
		{
			OptionsForm.ActiveForm.Close();
		}
	}
}
