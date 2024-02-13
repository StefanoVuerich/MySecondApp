// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var myMixer = new Mixer();
Console.WriteLine("Imposta il volume");
myMixer.SetVolume(Convert.ToInt32(Console.ReadLine()));
myMixer.CreateChannels();

Console.WriteLine($"Create {myMixer.InputChannels.Count} input channels, {myMixer.OutputChannels.Count} output channels");


