using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacancyManagement.Domain.Entities
{
	public class QuizAnswer
	{
		public int Id { get; set; }
		public string Item { get; set; }
		public string Title { get; set; }
		public bool IsCorrect { get; set; }
		public Quiz Quiz { get; set; }
		public int QuizId { get; set; }

	}
}
