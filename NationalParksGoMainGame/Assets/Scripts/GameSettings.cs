using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using uCPf;
using UnityEngine.UI;

public class GameSettings : MonoBehaviour {

    public Dropdown stateDropdown;
    public Dropdown parkDropdown;

    public int playerStateOption = 0;
    public int playerParkOption = 0;

    //declaration of all the string arrays for containing 3-4 base parks to pick from for the player's base park.  Initialized in SetStateParks()
    private string[] alabama, alaska, arizona, arkansas, california, colorado, connecticut, delaware, florida, georgia, hawaii, idaho, illinois, indiana, iowa, kansas, kentucky, louisiana,
        main, maryland, massachusetts, michigan, minnesota, mississippi, missouri, montana, nebraska, nevada, newHampshire, newJersey, newMexico, newYork, northCarolina, northDakota,
        ohio, oklahoma, oregon, pennsylvania, rhodeIsland, southCarolina, southDakota, tennessee, texas, utah, vermont, virginia, washington, westVirginia, wisconsin, wyoming;

    public string[] stateOptions = {
        "Alabama",
        "Alaska",
        "Arizona",
        "Arkansas",
        "California",
        "Colorado",
        "Connecticut",
        "Delaware",
        "Florida",
        "Georgia",
        "Hawaii",
        "Idaho",
        "Illinois",
        "Indiana",
        "Iowa",
        "Kansas",
        "Kentucky",
        "Louisiana",
        "Maine",
        "Maryland",
        "Massachusetts",
        "Michigan",
        "Minnesota",
        "Mississippi",
        "Missouri",
        "Montana",
        "Nebraska",
        "Nevada",
        "New Hampshire",
        "New Jersey",
        "New Mexico",
        "New York",
        "North Carolina",
        "North Dakota",
        "Ohio",
        "Oklahoma",
        "Oregon",
        "Pennsylvania",
        "Rhode Island",
        "South Carolina",
        "South Dakota",
        "Tennessee",
        "Texas",
        "Utah",
        "Vermont",
        "Virginia",
        "Washington",
        "West Virginia",
        "Wisconsin",
        "Wyoming"
    };



	// Use this for initialization
	public virtual void Start () {
        SetUpStateParks();

        /*playerColors = new Color[2];
        playerColors[0] = P1_DEFAULT;
        playerColors[1] = P2_DEFAULT;

        player1Color.color = P1_DEFAULT;
        player1Color.UpdateUI();

        player2Color.color = P2_DEFAULT;
        player2Color.UpdateUI();*/
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void UpdateStateChoice() {

        playerStateOption = stateDropdown.value;

        /*if (player1Dropdown.value != player2Dropdown.value)
        {
            player1DiseaseOption = player1Dropdown.value;
            //player2DiseaseOption = player2Dropdown.value;
        } else
        {
            player1Dropdown.value = player1DiseaseOption;
            //player2Dropdown.value = player2DiseaseOption;
        }*/

    }

    /*public virtual void UpdateColors() {

        if (playerColors.Length >= 2)
        {
            playerColors[0] = player1Color.color;
            playerColors[1] = player2Color.color;
        }

    }*/

    public void SetUpStateParks()
    {
        alabama =  new string[4];
        alabama[0] = "Gulf State Park";//Large body of water park
        alabama[1] = "DeSoto State Park";//Mountain-based park
        alabama[2] = "Roland Cooper State Park";//forest based park

        alaska = new string[4];
        alaska[0] = "Denali State Park";//forest-based
        alaska[1] = "Chugach State Park";//Mountain-based
        alaska[2] = "Wood-Tikchick State Park";//Larg body of water based
        alaska[3] = "Chena River State Recreation Area";//River-based

        arizona = new string[4];
        arizona[0] = "Catalina State Park";//Mountain-based
        arizona[1] = "Lost Dutchman State Park";//forest-based, desert theme (color things brown)
        arizona[2] = "Buckskin Mountain State Park";//River-based park

        arkansas = new string[4];
        arkansas[0] = "Lake Catharine State Park";//Large body of water park
        arkansas[1] = "Petit Jeane State Park";//River-based
        arkansas[2] = "Crater of Diamonds State Park";//mountain-based

        california = new string[4];
        california[0] = "Redwood National and State Parks";//forest-based park
        california[1] = "Henry W. Coe State Park";//mountain-based
        california[2] = "San Luis Reservoir State Recreation Area";//large body of water based
        california[3] = "Yosemite National Park";//forest-based

        colorado = new string[4];
        colorado[0] = "Rocky Mountain State Park";//mountain-based
        
        maryland = new string[4];
        maryland[0] = "Patapsco Valley State Park";//river-based
        maryland[1] = "Sandy Point State Park";//large body of water-based
        maryland[2] = "Pocomoke State Forest";//forest-based
        maryland[3] = "South Mountain State Park";//Mountain-based
    }
}
