//***************************************************************************
//
// Albina Isaeva
// Z2047166
// CSCI 473, Section 1
// Assignment 2 - Interfaces & Polymorphism
// Due Date: September 24th
// I certify that this is my own work and where appropriate an extension
// of the starter code provided for the assignment.
//
//***************************************************************************

using System;
using System.Collections.Generic;
using MediaPlayer.Media;
using MediaPlayer.Repositories;

namespace MediaPlayer
{
    class Program
    {
        static void PlayAll(IEnumerable<IPlayable> items)
        {
            foreach (var item in items)
            {
                item.Play();
            }
        }

        static void Main(string[] args)
        {
            IMediaRepository repository = new InMemoryMediaRepository();

            repository.Add(new Song("Blinding Lights", TimeSpan.FromMinutes(3)));
            repository.Add(new Video("Funny Cat Video", TimeSpan.FromMinutes(2)));
            repository.Add(new Podcast("Tech Talk", TimeSpan.FromMinutes(45)));

            List<IMedia> mediaList = new List<IMedia>(repository.GetAll());

            PlayAll(mediaList);

            foreach (var item in mediaList)
            {
                item.Stop();
            }

            List<IDownloadable> downloadables = new List<IDownloadable>();
            foreach (var item in mediaList)
            {
                if (item is IDownloadable downloadable)
                {
                    downloadables.Add(downloadable);
                }
            }

            foreach (var item in downloadables)
            {
                item.Download("/downloads");
            }
        }
    }
}