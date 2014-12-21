﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Data definitions are indexed by their anchor link, which should always be unique.
using MemberDefDict = System.Collections.Generic.Dictionary<string, HTMLGenerator.MemberFieldDefinition>;


namespace HTMLGenerator
{
	public partial class MainForm : Form
	{
		//Data definitions are indexed by their anchor link, which should always be unique.
		public MemberDefDict memberFieldData = new MemberDefDict(),
							 staticFieldData = new MemberDefDict(),
							 constantData = new MemberDefDict(),
							 subtypeData = new MemberDefDict();
		


		public MainForm()
		{
			InitializeComponent();
		}

		private void memberFields_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void classNameText_TextChanged(object sender, EventArgs e)
		{
			htmlFileLocationText.Text = systemNameText.Text + "/" + classNameText.Text;
		}

		private void systemNameText_TextChanged(object sender, EventArgs e)
		{
			htmlFileLocationText.Text = systemNameText.Text + "/" + classNameText.Text;
			systemHTMLText.Text = systemNameText.Text + ".html";
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}
	}
}
