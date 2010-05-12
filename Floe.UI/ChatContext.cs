﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Floe.Net;
using System.Windows;

namespace Floe.UI
{
	public sealed class ChatContext : DependencyObject
	{
		public IrcSession Session { get; private set; }

		public IrcTarget Target { get; private set; }

		public ChatContext(IrcSession ircSession, IrcTarget target)
		{
			this.Session = ircSession;
			this.Target = target;
		}
	}
}