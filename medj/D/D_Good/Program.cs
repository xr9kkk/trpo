// Телебоков А. И. SOLI(D) 5. Космос и научная фантастика

using D_Good.Models;
var luke = new Jedi("Люк", new SingleBladeLightsaber());
luke.Fight();
luke.PickUpLightsaber(new DoubleBladeLightsaber());
luke.Fight();

var anakin = new Jedi("Энакин", new SingleBladeLightsaber());
anakin.Fight();
anakin.PickUpLightsaber(new SithLightsaber());
anakin.Fight();