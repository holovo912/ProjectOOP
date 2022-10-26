/*
Name: Hoàng Long Vũ
ID: 21110113
Last updated: 23/9/2022
Purpose: Bài tây
Tính điểm xì dzách, Xếp bài theo tiến lên miền nam
*/
#include <iostream>
#include <cstring>
#include <time.h>
using namespace std;
#define MAX 52
#define MAXCARDS 13
#define MAXPLAYERS 17

struct CARD
{
    int number; //1 -> 13, 11 = J, 12 = Q, 13 = K
    int kind;   //1 = bich, 2 = chuon, 3 = ro, 4 = co
};

void createDeck(CARD deck[52]);
void shuffleDeck(CARD deck[]);

// In ra 1 lá bài
void printCard(CARD a);

// In toàn bộ 52 lá
void printDeck(CARD deck[]);

// In ra bài trên tay tất cả người chơi
void printCardHand(CARD hands[MAXPLAYERS][MAX], int players, int cards);

// Chia bài cho người chơi
void dealCard(CARD deck[], CARD hands[MAXPLAYERS][MAX], int players, int cards);

// Tính điểm bài cào của 3 lá
int countPoint_BaiCao(CARD c1, CARD c2, CARD c3);

// Tìm người win bài cào
void findWinner_BaiCao(CARD hands[MAXPLAYERS][MAX], int players);

// Tính số điểm của 1 tay bài theo trò chơi xì dzách
int blackJack(CARD hands[], int cards);

// Sắp xếp các lá bài trong tay bài tăng dần theo quy tắc bài "Tiến Lên miền Nam"
void sortHand_TienLen(CARD hands[], int cards);

// 6: sảnh rồng; 5: bốn quân 2; 4: sáu đôi; 3: bốn đôi thông; 2: tứ quý (không phải 2); 1: ba đôi thông; 0 = bình thường
int checkTienLen(CARD hands[]);

int main()
{
    CARD deck[MAX];
    CARD hands[MAXPLAYERS][MAX];
    createDeck(deck);
    shuffleDeck(deck);
    // players = số người chơi, cards = số lá bài mỗi người
    dealCard(deck, hands, 1, 13);
    printCardHand(hands, 1, 13);
    sortHand_TienLen(hands[0], 13);
    //findWinner_BaiCao(hands, 4);
    //checkTienLen(hands[0]);
    printCardHand(hands, 1, 13);
    //for (int i = 0; i < 3; i++)
    //{
       // cout << "Point #" << i + 1 << ": "<< blackJack(hands[i], 4) << endl;
    //}
    return 0;
}
void createDeck(CARD deck[MAX])
{
    int i = 0;
    for (int kind = 1; kind <= 4; kind++)
    {
        for (int number = 1; number <= 13; number++)
        {
            deck[i].number = number;
            deck[i].kind = kind;
            i++;
        }
    }
}
void shuffleDeck(CARD deck[])
{
    srand(time(NULL));
    // Xáo 40 lần
    for (int i = 0; i < 40; i++)
    {
        int a = (rand() % 52);
        int b = (rand() % 52);
        if (a != b)
            swap(deck[a], deck[b]);
    }
}
void printCard(CARD a)
{
    char t1[] = {'J', 'Q', 'K'};
    if (a.number == 1)
        cout << "A";
    else if (a.number > 10)
        cout << t1[a.number - 11];
    else
        cout << a.number; 
    char t2[][10] = {"bich", "chuon", "ro", "co"};   
    cout << t2[a.kind - 1];   
}
void printDeck(CARD deck[])
{
    for (int i = 0; i < MAX; i++)
    {
        printCard(deck[i]);
        cout << endl;
    }
}
void printCardHand(CARD hands[MAXPLAYERS][MAX], int players, int cards)
{
    for (int i = 0; i < players; i++)
    {
        cout << "Player #" << i + 1 << ": ";
        for (int j = 0; j < cards; j++)
        {
            printCard(hands[i][j]);
            cout << " ";
        }
        cout << endl;
    }
}
void dealCard(CARD deck[], CARD hands[MAXPLAYERS][MAX], int players, int cards)
{
    int i = 0;
    for (int p = 0; p < players; p++)
    {
        for (int c = 0; c < cards; c++)
        {
            hands[p][c] = deck[i];
            i++;
        }
    }
}
int countPoint_BaiCao(CARD c1, CARD c2, CARD c3)
{
    int sum = 0;
    if (c1.number > 10 && c2.number > 10 && c3.number > 10)
    {
        return 10;
    }
    if (c1.number < 10)
        sum += c1.number;
    if (c2.number < 10)
        sum += c2.number;
    if (c3.number < 10)
        sum += c3.number;
    return sum % 10;
}
void findWinner_BaiCao(CARD hands[MAXPLAYERS][MAX], int players)
{
    int count = 0;
    int winner[17];
    int pt = -1;
    for (int i = 0; i < players; i++)
    {
        int sum = countPoint_BaiCao(hands[i][0], hands[i][1], hands[i][2]);
        if (sum > pt)
        {
            winner[0] = i + 1;
            count = 1;
            pt = countPoint_BaiCao(hands[i][0], hands[i][1], hands[i][2]);
        }
        else if (sum == pt)
        {
            winner[count] = i + 1;
            count++;
        }
    }
    cout << "Winner: ";
    for (int i = 0; i < count; i++)
        cout << "#" << winner[i] << " ";
    cout << endl << "Point: " << pt;
}
int blackJack(CARD hands[], int cards)
{
    // Hàm trả về 23 nếu tay bài có đúng 2 quân A
    // Hàm trả về 22 nếu tay bài có đúng 2 quân, trong đó có 1A và 1 hình (hoặc 10)
    if (cards == 2)
    {
        if (hands[0].number == 1 && hands[1].number == 1)
            return 24;
        else if (hands[0].number == 1 && hands[1].number >= 10)
            return 23;
        else if (hands[1].number == 1 && hands[0].number >= 10)
            return 23;
    }
    // quân A có thể tính 1, 10 hoặc 11 sao cho có lợi nhất
    int count_A = 0, point = 0;
    for (int i = 0; i < cards; i++)
    {
        if (hands[i].number == 1)
        {
            count_A++;
            continue;
        }
        point += (hands[i].number >= 10 ? 10 : hands[i].number);
    }
    for (int i = 0; i < count_A; i++)
    {
        if (point + 11 <= 21 && i == count_A - 1)
            point += 11;
        else if (point + 10 <= 21 && i == count_A - 1)
            point += 10;
        else
            point += 1;
    }
    if (cards == 5 && point <= 21) return 22;
    return (point > 21 ? 0 : point);
}
void sortHand_TienLen(CARD hands[], int cards)
{
    for (int i = 0; i < cards; i++)
    {
        if (hands[i].number == 1)
            hands[i].number = 14;
        if (hands[i].number == 2)
            hands[i].number = 15;
    }
    for (int i = 0; i < cards - 1; i++)
    {
        for (int j = i + 1; j < cards; j++)
        {
            if (hands[i].number > hands[j].number)
                swap(hands[i], hands[j]);
            else if (hands[i].number == hands[j].number)
            {
                if (hands[i].kind > hands[j].kind)
                    swap(hands[i], hands[j]);
            }
        }
    }
    for (int i = 0; i < cards; i++)
    {
        if (hands[i].number == 14)
            hands[i].number = 1;
        if (hands[i].number == 15)
            hands[i].number = 2;
    }
}
int checkTienLen(CARD hands[])
{
    // Sảnh Rồng
    bool SanhRong[14], check = 1;
    memset(SanhRong, 0, sizeof(SanhRong));
    for (int i = 0; i < 13; i++)
        SanhRong[hands[i].number] = 1;

    for (int i = 1; i <= 13; i++)
    {
        if (SanhRong[i] == 0)
            check = 0;
    }
    if (check == 1)
        return 6;

    // Bốn quân 2
    int count = 0;
    for (int i = 0; i < 13; i++)
    {
        if (hands[i].number == 2)
            count++;
    }
    if (count == 4)
        return 5;

    // Sáu đôi
    int Count_num[14];
    memset(Count_num, 0, sizeof(Count_num));
    count = 0;
    for (int i = 0; i < 13; i++)
        Count_num[hands[i].number]++;
    for (int i = 1; i <= 13; i++)
    {
        if (Count_num[i] == 2)
            count++;
    }
    if (count == 6)
        return 4;

    // Bốn đôi thông
    for (int i = 3; i <= 10; i++)
    {
        if (Count_num[i] >= 2)
        {
            check = 1;
            for (int j = i + 1; j < i + 4; j++)
            {
                if (Count_num[j] < 2)
                    check = 0;
            }
            if (check == 1)
                return 3;
        }
    }

    // Tứ quý
    for (int i = 1; i <= 13; i++)
    {
        if (Count_num[i] == 4)
            return 2;
    }

    // Ba đôi thông
    for (int i = 3; i <= 11; i++)
    {
        if (Count_num[i] >= 2)
        {
            check = 1;
            for (int j = i + 1; j < i + 3; j++)
            {
                if (Count_num[j] < 2)
                    check = 0;
            }
            if (check == 1)
                return 1;
        }
    }
    return 0;
}
