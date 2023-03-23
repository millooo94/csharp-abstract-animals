using csharp_abstract_animals;

var pluto = new Cane();

pluto.Dormi();
pluto.Verso();
pluto.Mangia();

var flipper = new Delfino();

flipper.Dormi();
flipper.Verso();
flipper.Mangia();
FaiNuotare(flipper);

var tweety = new Passerotto();

tweety.Dormi();
tweety.Verso();
tweety.Mangia();
FaiVolare(tweety);

var pulcy = new PulcinellaDiMare();

FaiVolare(pulcy);
FaiNuotare(pulcy);

void FaiNuotare(INuotante animal)
{
    animal.Nuota();
}

void FaiVolare(IVolante animal)
{
    animal.Vola();
}