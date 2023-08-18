#pragma warning disable CS8618
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingPlanner.Models;
public class Rsvp
{
    [Key]
    public int RsvpId { get; set; }
    // The IDs linking to the adjoining tables   
    public int UserId { get; set; }
    public int WeddingId { get; set; }
    // Our navigation properties - don't forget the ?    
    public User? User { get; set; }
    public Wedding? Wedding { get; set; }
}
