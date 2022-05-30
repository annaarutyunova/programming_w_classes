public class Jumper {

    List<string> jumper = new List<string>();
    
    public Jumper() {
        jumper.Add(" ___ ");
        jumper.Add(@"/___\");
        jumper.Add(@"\   /");
        jumper.Add(@" \ /");
        jumper.Add("  o");
        jumper.Add(@" /|\");
        jumper.Add(@" / \");
    }


    public void UpdateJumper(){
        jumper.RemoveAt(0);
    }

    public void DisplayJumper() {
        foreach(string line in jumper) {
            Console.WriteLine(line);
        }
    }



}

