﻿using System;
using System.Windows.Forms;

namespace Testy_nowej_klasy
{
	public partial class Form1 : Form
	{
		public Form1() => InitializeComponent();

		private void BtnSpeakToMe_Click(object sender, EventArgs e) => MessageBox.Show("Długość wiadomości to " + Talker.BlahBlahBlah(TxtSayIt.Text, (int)TxtCount.Value));
	}
}