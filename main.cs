using System;

//Item class - handles finer attributes like if an item has been checked off or not
class item{
	private bool complete;
	private string toDo;

	//Items aren't done by default for obvious reasons;
	public item(string details){
		complete = false;
		toDo = details;
	}

	//I'm going to group the set and get methods
	private string getItem(){
		return toDo;
	}

	private bool isComplete(){
		return complete;
	}
	
	//Mutators
	private void setItem(string changes){
		toDo = changes;
	}

	private void nowComplete(){
		complete = true;
	}
}

//Todo List class - handles the adding, removing, and checking off of items
class TodoList {

	public void addItem(){

	}
}

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }
}