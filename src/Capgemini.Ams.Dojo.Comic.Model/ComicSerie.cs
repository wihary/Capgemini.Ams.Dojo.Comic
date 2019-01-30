namespace Capgemini.Ams.Dojo.Comic.Model
{
    using System;
    using System.Collections.Generic;

    public class ComicSerie : IResourceBase
    {
        public int Id { get; set; }

        public IEnumerable<string> RelatedComicBookNames { get; set; }

        public IEnumerable<ComicBook> RelatedComicBooks { get; set; }

        public string Name { get; set; }
    }
}