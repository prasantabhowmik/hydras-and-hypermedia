﻿using System;
using System.ServiceModel.Syndication;
using System.Text;
using System.Xml;

namespace RestInPractice.Exercises.Helpers
{
    public class EntryBuilder
    {
        private readonly SyndicationItem entry;

        public EntryBuilder()
        {
            entry = new SyndicationItem();
        }

        public EntryBuilder WithNorthLink(Uri uri)
        {
            entry.Links.Add(new SyndicationLink {Uri = uri, RelationshipType = "north"});
            return this;
        }

        public EntryBuilder WithSouthLink(Uri uri)
        {
            entry.Links.Add(new SyndicationLink {Uri = uri, RelationshipType = "south"});
            return this;
        }

        public EntryBuilder WithEastLink(Uri uri)
        {
            entry.Links.Add(new SyndicationLink {Uri = uri, RelationshipType = "east"});
            return this;
        }

        public EntryBuilder WithWestLink(Uri uri)
        {
            entry.Links.Add(new SyndicationLink {Uri = uri, RelationshipType = "west"});
            return this;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            using (var writer = XmlWriter.Create(sb))
            {
                new Atom10ItemFormatter(entry).WriteTo(writer);
                writer.Flush();
            }
            return sb.ToString();
        }
    }
}