using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;

namespace Movies.Models
{
    public class Peliculain : DropCreateDatabaseAlways<Peliculadb>
    {

        protected override void Seed(Peliculadb context)
        {
            base.Seed(context);

            //Create some photos
            var photos = new List<Pelicula>
            {
                new Pelicula {
                    Title = "Me standing on top of a mountain",
                    Poster = getFileBytes("\\Images\\flower.jpg"),
                    ImageMimeType = "image/jpeg",
                    Sinopsis = "I was very impressed with myself",
                    Director = "Fred",
                    Fecha_estreno = DateTime.Today
                },
                new Pelicula {
                    Title = "My New Adventure Works Bike",
                    Sinopsis = "It's the bees knees!",
                    Director = "Fred",
                    Poster = getFileBytes("\\Images\\flower.jpg"),
                    ImageMimeType = "image/jpeg",
                    Fecha_estreno = DateTime.Today
                },
                new Pelicula {
                    Title = "View from the start line",
                    Sinopsis = "I took this photo just before we started over my handle bars.",
                    Director = "Sue",
                    Poster = getFileBytes("\\Images\\flower.jpg"),
                    ImageMimeType = "image/jpeg",
                    Fecha_estreno = DateTime.Today
                }
            };
            photos.ForEach(s => context.Pelicula.Add(s));
            context.SaveChanges();

            //Create some comments
           
        }
        //This gets byte array for a file at the path specified
        //The path is relative to the route of the web site
        //It is used to seed images
        private byte[] getFileBytes(string path)
        {
            FileStream fileOnDisk = new FileStream(HttpRuntime.AppDomainAppPath + path, FileMode.Open);
            byte[] fileBytes;
            using (BinaryReader br = new BinaryReader(fileOnDisk))
            {
                fileBytes = br.ReadBytes((int)fileOnDisk.Length);
            }
            return fileBytes;
        }
    }
}