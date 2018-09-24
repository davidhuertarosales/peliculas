﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Movies.Models
{
    public class Comentario
    {
        //CommentID. This is the Primary Key
        public int ComentarioID { get; set; }

        //PhotoID. This is the ID of the photo that this comment relates to
        public int PeliID { get; set; }

        //UserName. This is the name of the user who made this comment
        public string UserName { get; set; }

        //Subject.
        [Required]
        [StringLength(250)]
        public string Critica { get; set; }

        //Body
        [DataType(DataType.MultilineText)]
        public string Body { get; set; }

        //Photo. This is the photo that this comment relates to as a navigation property
        public virtual Pelicula Pelicula { get; set; }
    }
}