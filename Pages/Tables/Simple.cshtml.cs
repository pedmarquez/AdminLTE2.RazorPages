using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace AdminLTE2.Web.Pages.Tables
{
    public class Simple : PageModel
    {
        public IEnumerable<Task> TasksData { get; } = new List<Task>
        {
            new Task
            {
                Id = 1,
                Name = "Update software",
                Progress = 55,
                ProgressBarCss = "progress-bar-danger",
                BadgeCss ="bg-red"
            },
            new Task
            {
                Id = 2,
                Name = "Clean database",
                Progress = 70,
                ProgressBarCss = "progress-bar-yellow",
                BadgeCss ="bg-yellow"
            },
            new Task
            {
                Id = 3,
                Name = "Cron job running",
                Progress = 30,
                ProgressBarCss = "progress-bar-primary",
                BadgeCss ="bg-light-blue"
            },
            new Task
            {
                Id = 4,
                Name = "Fix and squish bugs",
                Progress = 90,
                ProgressBarCss = "progress-bar-success",
                BadgeCss ="bg-green"
            }
        };
        public void OnGet()
        {

        }
    }

    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Progress { get; set; }
        public string ProgressBarCss { get; set; }
        public string BadgeCss { get; set; }

    }
}
