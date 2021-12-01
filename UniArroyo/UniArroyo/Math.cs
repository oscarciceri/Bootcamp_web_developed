namespace UniArroyo;

internal class Math : ClassType
{
    public int negative_points { get; set; }
    public int possitve_points { get; set; }
    public override int Calculate()
    {
        int rta = 0;
        
        if(cheating == 1)
        {
            rta = 0;
        }
        else
        {
            if(possitve_points > negative_points)
            {
                rta = 1;
            }
            else
            {
                rta = 0;
            }
            
        }
        return rta;
    }
}

