using OopNupat;
//Object oriented programming
//inheritance
//Abstraction
Dog dog_1 = new Dog("blue",23,"Bingo",3);
Bird bird_1 = new Bird("White", 2, "Eagle");

dog_1.CanFly(dog_1);
bird_1.CanFly(bird_1);
List<int> numbers = new List<int>();
numbers.Add(1);  
numbers.Add(2);  
numbers.Add(3);  
numbers.Add(4);

foreach (int i in numbers)
{
    Console.WriteLine(i);   
}

numbers.Remove(1);
numbers.Remove(2);
foreach (int i in numbers)
{
    Console.WriteLine(i);
}


List<Animal> animals = new List<Animal>();
animals.Add(new Dog("blue", 23, "Bingo", 3));
animals.Add(bird_1);

foreach (Animal animal in animals)
{
    animal.CanFly(animal);
}



//Console.WriteLine(dog_1.Color);
