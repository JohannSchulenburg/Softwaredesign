
// Pseudocode for learning to understand UML 
// UML Schematics: Umberto Falkenhagen
// Code: Johann Schulenburg

static void main(){
    //input
    mode = 1;
    int dirtyClothes=31;

    washingClothes(mode, dirtyClothes);
}

void washingClothes(int mode, int dirtyClothes){

    switch(mode){
        case 1: 
            addDetergent();
            addClothes();
            break;
        case 2:
            addDetergent();
            addSoftener();
            addClothes();
            break;
    }
    dirtyClothes = takeOutClothes(dirtyClothes);
    if (dirtyClothes>0){
        main();
    }
}

int takeOutClothes(int dirtyClothes){
    if (dirtyClothes > 20){
        return dirtyClothes-20;
    }
    else return 0;

}

