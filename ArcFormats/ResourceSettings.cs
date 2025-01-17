//! \file       ResourceSettings.cs
//! \date       2018 Jan 08
//! \brief      Persistent resource settings implementation.
//

using System;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Text;
using ArcFormats.Strings;

namespace GameRes.Formats
{
    internal class LocalResourceSetting : ResourceSettingBase
    {
        public override object Value {
            get { return ArcFormats.Properties.Settings.Default[Name]; }
            set { ArcFormats.Properties.Settings.Default[Name] = value; }
        }

        public LocalResourceSetting () { }

        public LocalResourceSetting (string name) : this (name, name) { }

        public LocalResourceSetting (string name, string text)
        {
            Name = name;
            Text = arcStrings.ResourceManager.GetString (text, arcStrings.Culture) ?? text;
        }
    }

    internal class EncodingSetting : LocalResourceSetting
    {
        static readonly Encoding DefaultEncoding = Encodings.cp932;

        public override object Value {
            get {
                try
                {
                    return Encoding.GetEncoding ((int)base.Value);
                }
                catch // fallback to CP932
                {
                    Trace.WriteLine (string.Format ("Unknown encoding code page {0}", base.Value));
                    return DefaultEncoding;
                }
            }
            set { base.Value = ((Encoding)value).CodePage; }
        }

        public EncodingSetting () { }

        public EncodingSetting (string name) : base (name) { }

        public EncodingSetting (string name, string text) : base (name, text) { }
    }

    [Export(typeof(ISettingsManager))]
    internal class SettingsManager : ISettingsManager
    {
        public void UpgradeSettings ()
        {
            if (ArcFormats.Properties.Settings.Default.UpgradeRequired)
            {
                ArcFormats.Properties.Settings.Default.Upgrade();
                ArcFormats.Properties.Settings.Default.UpgradeRequired = false;
                ArcFormats.Properties.Settings.Default.Save();
            }
        }

        public void SaveSettings ()
        {
            ArcFormats.Properties.Settings.Default.Save();
        }
    }
}
