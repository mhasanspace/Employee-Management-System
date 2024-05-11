namespace EMS.Domain.Common
{
    public abstract class BaseModelEntity
    {
        public int Id { get; set; }
        //public int CreateBy { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        //public int LastModifyBy { get; set; }
        public string LastModifyBy { get; set; }

        public DateTime? LastModifyDate { get; set; }
    }
}
