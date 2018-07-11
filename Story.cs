using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_App {
    class Story {
        //the story and its different choices A & B stand for choices (displays different choise based on choice made in line above)
        public static string[] PartOne = {
   "You just woke up in a strange bed….. \nYou open your eyes and look around you, all you see at first sight is walls and... What's that?! Is that a... \nToilet?! With a... Teddy bear sitting on it?!\n\nWhat do you do? \nA). Remove the teddy bear and go to the toilet, you need to take a shit. \nB). Check the rest of the room.",
   //A
   "\nYou walk towards the toilet, drop your pants and start working on your masterpiece. \nWhile sitting on the toilet you look around. W..Wait a second.. Are those prison bars? \nAM I IN PRISON?! You quickly wrap up on your chocolate banana and walk towards the bars.",
   //B
   "\nWhile looking around you notice something... \nW.. Wait a second... Are those prison bars? \nAM I IN PRISON?! You quickly head towards the bars.",
   "\nYou look through the bars and notice you’re indeed in a prison. \nYou see a large row of prison cells to your right and even more prison cells straight ahead of the big room with tables and guards walking around. \n\nRight in front of you, you see stairs that lead to the upper level of the prison block. ",

   "You stand in front of the prison bars, wondering how you could’ve ended up in a prison. \nYou see a guard walking closer and call him to ask how you got here. \n\nWhat do you say? \nA). Excuse me sir, may i ask you what happened & how i got here? \nB). Hey bastard! What the hell is going on here?!",
   //A
    "\nThe guards walks toward you and says: Look who is finally awake. \nYou don’t know what happened do you? \nWhile the guard walks away you hear him mumble something about memory loss.",
    //B
   "\nThe guard immediately walks towards you, pulls his hands though the prison bars and grabs you by your shirt. \nYou better calm down kid, you don’t want anything bad to happen, do you? \nThe guard turns around and continues his patrol route.",
   "\nYou stare down the guard with an angry face. Until suddenly you hear music. As you look to your right, \nyou see a weird floating robot with various antennas."
  };
        public static string[] PartTwo = {
   "Just a few seconds later you hear someone in the cell next to you whisper. \n\nPsst... you’re the new one aren’t you? You’re probably wondering what happened and how you got here.",
   "Well... don’t bother asking anyone. None of us know how we got here or what happened. \nBut tell me... What's your name? \n\nWhat do you say? \nA). " + Game.CharacterName + " \nB). None of your business",
   //A
   "\nWell nice to meet you " + Game.CharacterName + ", I’m Brian.",
   //B
   "\nWhy so rude? What did i do to you?! Whatever Cpt. Douchebag, I’m Brian.",
   "Listen up, You want to get out of here don't you? \nOf course i do, why? \nI got a plan. \n\nAs Brian points to the right side of the prison block he says: \nSee that door in the back there? It leads outside. \nEvery day at 14:00 They let us outside until 17:00.",
   "\nMeet me once we’re outside. I’ll tell you the rest. \nHow long until they let us out? \nBrian mumbles something about being blind and says: What are you blind? There’s a clock to your left. \n\nWhat do you do? \nA). You Quietly check the clock \nB). Tell Brian to take it easy",
    //B
   "\nTake it easy man. No need to be rude.",
   "\nYou check the clock with a weird cartoon character behind it and see it’s 12:00. \n\nWhat do you do? \nA). Go lay on bed and sleep until it’s time \nB). Go lay on bed and sing a song",
    //A
    "\nAs you lay down on bed you feel your eyes getting tired. You slowly close your eyes and fall asleep.",
    //B
    "\nAs you lay down you start singing:",
    "Cause I got spurs that jingle, jangle, jingle \nJingle, jangle \nAs I go ridin' merrily along \nJingle, jangle \nAnd they sing, Oh, ain't you glad you're single? \nJingle, jangle \nAnd that song ain't so very far from wrong \nJingle, jangle",
    "\nYou get interrupted. Hey! Shut up! Keep it down! \nYou slowly stop singing and feel your eyes getting tired. You slowly close your eyes and fall asleep.",
  };
        public static string[] PartThree = {
            "You wake up from the sound of keys against the prison bars. You turn around and see its 16:55. \nA guard enters your cell and says: Time for a walk kid. \nThe guard pushes you outside your cell and as you look to your right, \nyou see Brian is also getting escorted out of his \ncell. \n\nThe guard looks at you and says: Don’t try anything funny kid. He leads you outside while \nstrictly aiming his what appears to be a laser rifle at you.",
            "\nOnce outside you look around and notice there’s a big wall made out of scrap around the whole prison. \nYou're confused and start walking towards Brian. \nHalfway through 2 big guys stop you and say: You’re the new kid aren’t you?  " + Game.CharacterName + " right? \nThat’s what we heard at least. \n\nYou look at them and say: What the hell do you guys want?!",
            "As you say this you hear Brian shout: Hey Tyler,Dean. Leave him alone. Or do you want trouble again? \n\nTyler and Dean step aside and as you reach Brian you ask him: Again? What happened? \nBrian shrugs his shoulders and says: I’ll tell you later.",
            "Brian scrapes his throat and says: So... See that guard post over there? Behind it there’s a door. \nWe don’t know what's behind it, but it’s the only way in and out. \n\nYou look confused and ask: What is the wall around the prison supposed to mean? \nBrian looks around and says: We don’t know. \nNobody knows what outside of these walls, but there must be a reason it's there. \n\nWhat do you do? \nA). Ask what’s the plan?\nB). Suggest a plan",
            //A
            "\nWell it can’t be worse than this prison. We need to get out of here. What's the plan?",
            //B
            "\nYou whisper: Alright, you distract the guard, I will tackle him and take his laser rifle. As soon as we..  \n--YOU GET INTERRUPTED-- \nBrian says: Take it easy man. I’ve got a much better plan. Listen up.",
            "You remember those 2 guys from earlier? Tyler & Dean. \nYeah.. They’re pretty dumb. I’ll set them up against each other to create a distraction. \nAs soon as the guards are distracted we sneak towards the guard post. \n\nThere is only 1 guard there right now and with all the other guards distracted by the fight, taking down the guard \nat the guard post shouldn't be a problem.",
            "\nWhat do you do? \nA). Agree?\nB). Disagree, your plan is much better",
            //A
            "\nSounds good, let’s go.",
            //B
            "\nThat sounds ridiculous. We go with my plan, or no plan at all.",
        };
        //If chosen Option A last Part
        public static string[] PartFourA = {
            "Alright, watch this. Hey Tyler, Dean! Have you told each other? \nTyler and Dean walk towards Brian. \nTold each other what? Brian smiles and says: Well Tyler, didn’t you come to me yesterday \nto complain about \nhow stupid Dean is? \n\nDean interrupts as he screams YOU SAID WHAT?! ",
            "\nBrian continues by saying: Hold on there Dean, just last week you said Tyler is a pussy \nand just follows you around everywhere. \n\nThis time Tyler interrupts and starts screaming: YOU SAID THAT?",
            "\nBrian quickly grabs you and whispers: Quick! Let's go! \nYou look behind you to see what Tyler & Dean are doing and see them starting to push each other. \nYou turn around to Brian and before you can say anything you see him grin while saying: Works everytime. \n\nWhat do you do? \nA). Laugh\nB). Tell Brian that was stupid",
            //A
            "\nHa, good one. That will keep the guards busy for a while.",
            //B
            "\nThat was stupid, I bet you’re not much smarter than they are. \nBrian turns towards you and says: Easy there " + Game.CharacterName + ", before you’re the next who has a problem.",
            "\nWhile walking towards the guard post you check around once more.\nYou see multiple prisoners attacking the guards who came to pull Tyler and Dean apart.\nYou look behind the riot and see a glimpse of what appears to be another floating robot. \nOne with a large number of hands. Before you can take a good look, you see it getting smashed by one of the prisoners",
        };
        //If chosen Option B last Part
        public static string[] PartFourB = {
            "Are you out of your mind? Why would we do that? \nYou say: It’s my plan or no plan. \n\nDesperate to get out of the prison Brian says: Fine. But if anything goes wrong, it’s all your fault.",
            "\nYou see Brian running towards the Guard and pushing the guard against the ground. \nYou shout: Hey that wasn’t the plan! \nBrian quickly throws the laser rifle towards you and you immediately aim towards another guard and shout: \nEveryone Back off or he’s dead!",
            "\nWhile aiming on the guard, you and Brian back off slowly towards the front desk. \nSuddenly you hear a gunshot and see your laser-rifle fall out of your hand. \n2 other guards are aiming towards you and Brian. \n\nYou hear Brian whistle and you see 5 big guys running towards the guards. \nYou ask who are they? Brian continues to say, oh just some friends backing me up. \n\nWhat do you do? \nA). Be nice\nB). Act like a douche",
            //A
            "\nAlways handy to have backup.",
            //B
            "\nFriends? Like anyone wants to be your friend.",
            "\nYou see Brian's friends taking down the guards, as well as a weird looking robot with a large number of hands. \nYou and Brian quickly continue your way to the guard post.",
        };
        public static string[] PartFive = {
            "While coming closer to the guard post you hear the guard shout: Hey! Back off! \nBrian continues to say: Allow me. As he picks up a stone and throws it right at the hand of the guard. \nThe guard drops his gun out of pain. \n\nWhat do you do? \nA). Slap the guard\nB). Grab the gun and shoot the guard",
            //A
            "You start running towards the guard and before he can pick up the gun you grab his face and slam it on the desk inside. \nThe guard hits you in the face with his elbow. \nYou back off and see Brian picking up the gun and shooting the guard. \nBrian shouts: Why did you not pick-up the gun?! it was right there!",
            //B
            "You dive for the gun and while still on the ground you shoot the guard right in his testicles. \nThe guard drops on his knees and as you stand up you finish him with a shot straight to the head. \nBrian turns to you and says: Nice shot man.",
            "Brian continues to say: Quick search for the keys! \n\nAs you and Brian both look around you notice a bunch of keys laying on the left side of the desk next to a coffee mug. \nYou grab the keys and say: Quick follow me! \nYou and Brian run towards the door and as you are trying to find the right key you hear gunshots.",
            "You turn around and see blood pouring out of Brian. \nAs Brian drops on the ground you feel a click in your other hand. \n\nThe door is open! As you run through the door one of the bullets from the guards hits the key inside the door. \nThe key breaks. You quickly close the door behind you.",
            "\nYou hear the guards scream: FUCK! As they try to open the door. \nGet the key out! Quick! \nI’m trying! It’s stuck!",
            "You notice music coming from a gas station further down the road. \nAs you run towards the gas station you look around. \nEverything is dead... Buildings are destroyed and there is no sign of life.",
            "\nAs you enter the gas station, you shout: Anybody there?!?! \nNo reaction... \n\nYou walk around and all you see are posters with the same cartoon character you saw earlier. \nWhat’s going on? Why is everything destroyed? You open the cash desk and a bunch of bottle caps come flying out. \n\nConfused and full of questions you continue your journey.....",
        };
    }
}
