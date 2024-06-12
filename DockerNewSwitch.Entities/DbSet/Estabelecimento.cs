namespace DockerNewSwitch.Entities.DbSet
{
    public class Estabelecimento 
    {

        public Estabelecimento() 
        {
            Msgs = new HashSet<Msg>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string CardAcceptorIC { get; set; }
        public virtual ICollection<Msg> Msgs { get; set; }
    }
}
