/*
 * Created by SharpDevelop.
 * User: Leon
 * Date: 28/05/2013
 * Time: 07:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;  // Required for StructLayout
using System.Drawing.Imaging;  // Required for PixelFormat;
using System.Threading;
using System.Configuration;


namespace vzMapper
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public readonly Int32 SHUTTERSPEED = 500;  // The delay between bringing the window to the fore and taking a screenshot
		
		public IEnumerable<System.Diagnostics.Process> allProcesses = Process.GetProcesses();
		public System.Diagnostics.Process targetProcess;
		
		public static Int32 worldImageTopLeftCornerX;
		public static Int32 worldImageTopLeftCornerY;
		public static Int32 worldImageWidth;
		public static Int32 worldImageHeight;
		public static Int32 leftArrowPosX;
		public static Int32 leftArrowPosY;
		public static Int32 upArrowPosX;
		public static Int32 upArrowPosY;
		public static Int32 downArrowPosX;
		public static Int32 downArrowPosY;
		public static Int32 rightArrowPosX;
		public static Int32 rightArrowPosY;
		
		[StructLayout(LayoutKind.Sequential)]
		public struct Rect
		{
		    public Int32 left;
		    public Int32 top;
		    public Int32 right;
		    public Int32 bottom;
		}
		
		[DllImport("user32.dll")]
		private static extern Int32 SetForegroundWindow(IntPtr hWnd);
		
		private const Int32 SW_RESTORE = 9;
		
		[DllImport("user32.dll")]
		private static extern IntPtr ShowWindow(IntPtr hWnd, int nCmdShow);
		
		[DllImport("user32.dll")]
		public static extern IntPtr GetWindowRect(IntPtr hWnd, ref Rect rect);
		
		public Bitmap CaptureApplicationScreenshot(IntPtr myHandle, Int32 startX = 0, Int32 startY = 0, Int32 widthArg = 0, Int32 heightArg = 0) {
		    // You need to focus on the application
		    SetForegroundWindow(myHandle);
		    // Sleep a little between attempting to bring the window to the fore and taking its picture:
		    Thread.Sleep(SHUTTERSPEED);		    
		    Rect rect = new Rect();
		    IntPtr error = GetWindowRect(myHandle, ref rect);
		    while (error == (IntPtr)0)
		    {
		        error = GetWindowRect(myHandle, ref rect);
		    }
		    Int32 height;
		    Int32 width;
		    if (widthArg == 0) {
		    	startX = 0;
		    	width = rect.right - rect.left;
		    } else {
		    	width = widthArg;
		    }
		    if (heightArg == 0) {
		    	startY = 0;
		    	height = rect.bottom - rect.top;
		    } else {
		    	height = heightArg;
		    }
		    Bitmap bmp = new Bitmap(width, height, PixelFormat.Format32bppArgb);
		    Graphics.FromImage(bmp).CopyFromScreen(rect.left + startX,  // rect.left is the x pos of the left edge of window relative to screen
		                                           rect.top + startY,   // rect.top is the y pos of the top edge of window relative to screen
		                                           0,
		                                           0,
		                                           new Size(width, height),
		                                           CopyPixelOperation.SourceCopy);
		    return bmp;
		}// CaptureApplicationScreenshot


		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			
			// Load settings from app.config:
			worldImageTopLeftCornerX = Convert.ToInt32( ConfigurationManager.AppSettings["worldImageTopLeftCornerX"] );
			worldImageTopLeftCornerY = Convert.ToInt32( ConfigurationManager.AppSettings["worldImageTopLeftCornerY"] );
			worldImageWidth = Convert.ToInt32( ConfigurationManager.AppSettings["worldImageWidth"] );
			worldImageHeight = Convert.ToInt32( ConfigurationManager.AppSettings["worldImageHeight"] );
			leftArrowPosX = Convert.ToInt32( ConfigurationManager.AppSettings["leftArrowPosX"] );
			leftArrowPosY = Convert.ToInt32( ConfigurationManager.AppSettings["leftArrowPosY"] );
			upArrowPosX = Convert.ToInt32( ConfigurationManager.AppSettings["upArrowPosX"] );
			upArrowPosY = Convert.ToInt32( ConfigurationManager.AppSettings["upArrowPosY"] );
			downArrowPosX = Convert.ToInt32( ConfigurationManager.AppSettings["downArrowPosX"] );
			downArrowPosY = Convert.ToInt32( ConfigurationManager.AppSettings["downArrowPosY"] );
			rightArrowPosX = Convert.ToInt32( ConfigurationManager.AppSettings["rightArrowPosX"] );
			rightArrowPosY = Convert.ToInt32( ConfigurationManager.AppSettings["rightArrowPosY"] );
			

		}

		
		void updateWindowsProcesses() {
			windowsCmb.Items.Clear();
			allProcesses = Process.GetProcesses().Where(p => p.MainWindowHandle != IntPtr.Zero && p.MainWindowTitle != "");
			foreach (var myProcess in allProcesses) {
   				Debug.WriteLine(myProcess.MainWindowTitle);
   				windowsCmb.Items.Add(myProcess.MainWindowTitle);
  			}
		}
		
		void WindowsCmbSelectedIndexChanged(object sender, EventArgs e)
		{
			targetProcess = allProcesses.ElementAt(windowsCmb.SelectedIndex);
			Debug.WriteLine("targetProcess is now: " + targetProcess.MainWindowTitle);
			
		}
		
		void WindowsCmbDropDown(object sender, EventArgs e)
		{
			
			updateWindowsProcesses();
			
		}

		void SnapshotBtnClick(object sender, EventArgs e)
		{
			//updateWindowsProcesses();
			if (targetProcess != null && allProcesses.Contains(targetProcess) ) {
				Bitmap myScreenshot = CaptureApplicationScreenshot(targetProcess.MainWindowHandle, worldImageTopLeftCornerX, worldImageTopLeftCornerY, worldImageWidth, worldImageHeight);
				myScreenshot.Save("myScreenshot.png", ImageFormat.Png);
				localePcb.Image = myScreenshot;
			} else {
				Debug.WriteLine("targetProcess was not found in allProcesses");
			}
		}
		
		void OptionsTmiClick(object sender, EventArgs e)
		{
			OptionsForm myOptionsForm = new OptionsForm();
            myOptionsForm.ShowDialog();
		}
		
		void ExitTmiClick(object sender, EventArgs e)
		{
			MainForm.ActiveForm.Close();
		}
	}// class MainForm	
	
	
}// namespace vzMapper
