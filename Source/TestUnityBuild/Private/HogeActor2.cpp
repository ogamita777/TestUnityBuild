#include "HogeActor2.h"

void AHogeActor2::BeginPlay()
{
	Super::BeginPlay();
	
	// KismetSystemLibrary.h は HogeActor2.cppではincludeされていない
	UKismetSystemLibrary::DrawDebugSphere(GetWorld(), GetActorLocation(), 100.0f, 12, FLinearColor::Red, 30.0f);

}
