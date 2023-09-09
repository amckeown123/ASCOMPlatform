﻿using System;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using static ASCOM.Utilities.Global;
using static ASCOM.Utilities.RegistryAccess;

namespace ASCOM.Utilities
{

    public partial class VersionForm
    {
        public VersionForm()
        {
            InitializeComponent();
        }

        private void VersionForm_Load(object sender, EventArgs e)
        {
            RegistryKey ProfileKey;

            try
            {

                using (var Profile = new RegistryAccess())
                {
                    ProfileKey = Profile.OpenSubKey3264(RegistryHive.LocalMachine, @"SOFTWARE\ASCOM\Platform", false, RegWow64Options.KEY_WOW64_32KEY);

                    NameLbl.Text = Conversions.ToString(ProfileKey.GetValue("Platform Name", "Unknown Name"));
                    Version.Text = Conversions.ToString(ProfileKey.GetValue("Platform Version", "Unknown Version"));
                    BuildSha.Text = Application.ProductVersion;

                    ProfileKey.Close();
                }
            }

            catch (Exception ex)
            {
                Utilities.Global.LogEvent("DiagnosticsVersionForm", "Exception", EventLogEntryType.Error, EventLogErrors.DiagnosticsLoadException, ex.ToString());
                Interaction.MsgBox("Unexpected exception loading Version Form: " + ex.ToString(), MsgBoxStyle.Critical, "Version load error");
            }

        }
    }
}