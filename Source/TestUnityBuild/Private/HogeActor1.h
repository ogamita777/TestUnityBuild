#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Actor.h"
#include "HogeActor1.generated.h"

UCLASS()
class AHogeActor1 : public AActor
{
	GENERATED_BODY()

protected:
	virtual void BeginPlay() override;
};
