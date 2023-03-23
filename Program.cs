using csharp_abstract_animals;

var flipper = new Delfino();

flipper.Dormi();
flipper.Verso();
flipper.Mangia();
FaiNuotare(flipper);

var pluto = new Cane();

pluto.Dormi();
pluto.Verso();
pluto.Mangia();

var tweety = new Passerotto();

FaiVolare(tweety);


void FaiNuotare(INuotante animal)
{
    animal.Nuota();
}

void FaiVolare(IVolante animal)
{
    animal.Vola();
}
