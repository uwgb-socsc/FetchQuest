using UnityEngine;
using System.Collections;

public class Attack  {
    public string name { get; set; } //warning here would be solved by not inheriting from MonoBehaviour
    public string description { get; set; }
    public double power { get; set; }
    public double accuracy { get; set; }
    public enum Special {spec1, spec2, spec3, spec4, spec5, spec6 }; //these are special effects rename them later. SERIOUSLY DO NOT LEAVE THEM THIS WAY WHEN WE DECIDE!
    public Special attackSpecial;
	
	
	}

