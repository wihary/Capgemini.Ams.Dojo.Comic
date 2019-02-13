namespace Capgemini.Ams.Dojo.Donet.Comic.Business
{
    using System;
    using Capgemini.Ams.Dojo.Donet.Comic.Model;

    public class ComicBookLogic
    {
        public ComicBook GetComicBook() => new ComicBook
        {
            Id = 42,
            Title = "This is a ComicBook title",
            ParutionDate = DateTime.Now
        };
    }
}