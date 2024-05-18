SELECT V.num, V.cru
FROM VINS V
WHERE V.num IN (
    SELECT R.nvin
    FROM RECOLTES R
    JOIN PRODUCTEURS P ON P.num = R.nprod
    WHERE R.nprod IN (
        SELECT DISTINCT P1.num
        FROM PRODUCTEURS P1
        JOIN PRODUCTEURS P2 ON P2.region != P1.region
        GROUP BY P1.num
        HAVING COUNT(P1.num) >= 2
    )
    GROUP BY nvin
    HAVING COUNT(nprod) >= 2
);