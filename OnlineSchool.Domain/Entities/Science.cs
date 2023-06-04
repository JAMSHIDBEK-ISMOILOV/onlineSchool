using System;
using System.Collections;
using System.Collections.Generic;

namespace OnlineSchool.Domain.Entities
{
	public class Science
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int TeacherId { get; set; }
		public int StudentId { get; set; }

		public Teacher Teacher { get; set; }
		public Student Student { get; set; }
	}
}

