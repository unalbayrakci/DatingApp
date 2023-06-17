using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{

    [Table("Photos")]
    public class Photo
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public bool IsMain { get; set; }
        public string PublicId { get; set; }

        public int AppUserId { get; set; }             // Following 2 lines of codes are to make relations between every photo in the table with an user. 
        public AppUser AppUser { get; set; }            //Otherwise, there might be photos which are not related with any user
    }
}