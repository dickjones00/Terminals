﻿namespace Rug.Cmd
{
    using System;
    using System.Collections.Generic;

    public class StringListArgument : BaseArgument
    {
        private string m_Name;
        public List<string> Value;

        public StringListArgument(string name, string shortHelp, string help) : base(shortHelp, help)
        {
            this.Value = new List<string>();
            this.m_Name = name;
        }

        public override string ArgumentString()
        {
            return (" " + this.m_Name);
        }

        public override bool Parse(ArgumentParser parser, string key, string[] values, ref int index)
        {
            if ((index + 1) >= values.Length)
            {
                throw new Exception(string.Format(Strings.ArgumentParser_InvalidArgument, key));
            }
            return true;
        }

        public override void Reset()
        {
            this.Value.Clear();
            base.Reset();
        }

        public override bool SetValue(string value)
        {
            this.Value.Add(value);
            return true;
        }

        public override object ObjectValue
        {
            get
            {
                return this.Value;
            }
        }
    }
}

