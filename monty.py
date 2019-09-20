def method():
    import random

    #set valuable
    stayWinning = 0
    changeWinning = 0
    losing = 0

    # CHANGING
    for i in range(0,100000):
        winDoor = random.randint(0,3)
        pickDoor = random.randint(0,3)

        if (winDoor!=pickDoor):
            changeWinning=changeWinning+1
        else:
            losing=losing+1

    # STAYING
    for i in range(0,100000):
        winDoor = random.randint(0,3)
        pickDoor = random.randint(0,3)

        if (winDoor==pickDoor):
            stayWinning=stayWinning+1
        else:
            losing=losing+1



    print('Staying winning in 100000 times = %d' %(stayWinning))

    print('Changing Winning in 100000 times = %d' %(changeWinning))






method()
