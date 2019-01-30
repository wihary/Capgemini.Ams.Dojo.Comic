namespace Capgemini.Ams.Dojo.Comic.Model
{
    using System;

    public class ComicBook : IResourceBase
    {
        public int Id { get; set; }

        public int SerieId { get; set; }

        public string SerieName { get; set; }

        public string Title { get; set; }

        public DateTime ParutionDate { get; set; }

        public int IssueNumber { get; set; }
    }
}