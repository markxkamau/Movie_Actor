using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models
{
    public class ActorGenreViewModel
    {
        public List<Actor>? Actors { get; set; }
        public SelectList? Genres { get; set; }
        public string? ActorGenre { get; set; }
        public string? SearchString { get; set; }
    }
}