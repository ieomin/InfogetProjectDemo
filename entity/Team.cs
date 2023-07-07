namespace ProjectDemo.entity
{
    public class Team
    {
        private string name;
        private List<Member> members = new List<Member>();

        public Team(string name)
        {
            this.Name = name;
        }

        public string Name { get => name; set => name = value; }
        public List<Member> Members { get => members; set => members = value; }

        public void addTeamMembers(Member member)
        {
            this.Members.Add(member);
        }
    }
}