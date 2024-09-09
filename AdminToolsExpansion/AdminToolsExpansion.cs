using AdminTools;
using Exiled.API.Features;
using PlaceholderAPI.API.Abstract;

namespace AdminToolsExpansion
{
    public class AdminToolsExpansion : PlaceholderExpansion
    {
        public override string Author { get; set; } = "NotZer0Two";
        public override string Identifier { get; set; } = "admintools";
        public override string RequiredPlugin { get; set; } = "Admin Tools";

        public override string OnRequest(Player player, string param)
        {
            switch (param.ToLower())
            {
                case "isoverwatch":
                    return Main.Overwatch.Contains(player.UserId).ToString();

                case "isjailed":
                    return Main.JailedPlayers.ContainsKey(player.UserId).ToString();

                case "ismuted":
                    return Main.RoundStartMutes.Contains(player).ToString();

                case "hasinstakill":
                    return Main.InstantKill.Contains(player).ToString();

                case "hasprygate":
                    return Main.PryGate.Contains(player).ToString();

                case "hasbreakdoors":
                    return Main.BreakDoors.Contains(player).ToString();
            }

            return null;
        }
    }
}
