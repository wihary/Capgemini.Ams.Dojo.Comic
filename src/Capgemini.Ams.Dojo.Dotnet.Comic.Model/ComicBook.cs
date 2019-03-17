namespace Capgemini.Ams.Dojo.Dotnet.Comic.Model
{
    using System;

    public class ComicBook : IResourceBase
    {
        /// <summary>
        ///     Id du comicBook utilise par la source données
        /// </summary>
        /// <value></value>
        public int Id { get; set; }

        public int SerieId { get; set; }

        public string SerieName { get; set; }

        public string Title { get; set; }

        public DateTime ParutionDate { get; set; }

        public int IssueNumber { get; set; }
    }
}