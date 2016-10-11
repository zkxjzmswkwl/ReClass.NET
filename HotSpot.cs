﻿using ReClassNET.Nodes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReClassNET
{
	enum HotSpotType
	{
		None,
		Edit,
		OpenClose,
		Select,
		Drop,
		Click,
		ChangeA,
		ChangeX,
		Delete,
		RTTI,
		Address,
		Name,
		Comment
	}

	class HotSpot
	{
		public const int NoneId = -1;
		public const int AddressId = 100;
		public const int NameId = 101;
		public const int CommentId = 102;

		public int Id { get; set; }
		public HotSpotType Type { get; set; }
		public int Level { get; set; }

		public string Text { get; set; }
		public BaseNode Node { get; set; }

		public Rectangle Rect { get; set; }

		public IntPtr Address { get; set; }
	}
}