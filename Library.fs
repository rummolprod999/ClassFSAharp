﻿namespace ClassFSAharp

type Tools() =
    static member GetRegionString(s : string) : string =
        let sLower = s.ToLower()
        match sLower with
        | s when s.Contains("отсуств") -> ""
        | s when s.Contains("белгор") -> "белгор"
        | s when s.Contains("брянск") -> "брянск"
        | s when s.Contains("владимир") -> "владимир"
        | s when s.Contains("воронеж") -> "воронеж"
        | s when s.Contains("иванов") -> "иванов"
        | s when s.Contains("калужск") -> "калужск"
        | s when s.Contains("костром") -> "костром"
        | s when s.Contains("курск") -> "курск"
        | s when s.Contains("липецк") -> "липецк"
        | s when s.Contains("москва") -> "москва"
        | s when s.Contains("московск") -> "московск"
        | s when s.Contains("орлов") -> "орлов"
        | s when s.Contains("рязан") -> "рязан"
        | s when s.Contains("смолен") -> "смолен"
        | s when s.Contains("тамбов") -> "тамбов"
        | s when s.Contains("твер") -> "твер"
        | s when s.Contains("тульс") -> "тульс"
        | s when s.Contains("яросл") -> "яросл"
        | s when s.Contains("архан") -> "архан"
        | s when s.Contains("вологод") -> "вологод"
        | s when s.Contains("калинин") -> "калинин"
        | s when s.Contains("карел") -> "карел"
        | s when s.Contains("коми") -> "коми"
        | s when s.Contains("ленинг") -> "ленинг"
        | s when s.Contains("мурм") -> "мурм"
        | s when s.Contains("ненец") -> "ненец"
        | s when s.Contains("новгор") -> "новгор"
        | s when s.Contains("псков") -> "псков"
        | s when s.Contains("санкт") -> "санкт"
        | s when s.Contains("адыг") -> "адыг"
        | s when s.Contains("астрахан") -> "астрахан"
        | s when s.Contains("волгог") -> "волгог"
        | s when s.Contains("калмык") -> "калмык"
        | s when s.Contains("краснод") -> "краснод"
        | s when s.Contains("ростов") -> "ростов"
        | s when s.Contains("дагест") -> "дагест"
        | s when s.Contains("ингуш") -> "ингуш"
        | s when s.Contains("кабардин") -> "кабардин"
        | s when s.Contains("карача") -> "карача"
        | s when s.Contains("осети") -> "осети"
        | s when s.Contains("ставроп") -> "ставроп"
        | s when s.Contains("чечен") -> "чечен"
        | s when s.Contains("башкор") -> "башкор"
        | s when s.Contains("киров") -> "киров"
        | s when s.Contains("марий") -> "марий"
        | s when s.Contains("мордов") -> "мордов"
        | s when s.Contains("нижегор") -> "нижегор"
        | s when s.Contains("оренбур") -> "оренбур"
        | s when s.Contains("пензен") -> "пензен"
        | s when s.Contains("пермс") -> "пермс"
        | s when s.Contains("самар") -> "самар"
        | s when s.Contains("сарат") -> "сарат"
        | s when s.Contains("татарс") -> "татарс"
        | s when s.Contains("удмурт") -> "удмурт"
        | s when s.Contains("ульян") -> "ульян"
        | s when s.Contains("чуваш") -> "чуваш"
        | s when s.Contains("курган") -> "курган"
        | s when s.Contains("свердлов") -> "свердлов"
        | s when s.Contains("тюмен") -> "тюмен"
        | s when s.Contains("ханты") -> "ханты"
        | s when s.Contains("челяб") -> "челяб"
        | s when s.Contains("ямало") -> "ямало"
        | s when s.Contains("алтайск") -> "алтайск"
        | s when s.Contains("алтай") -> "алтай"
        | s when s.Contains("бурят") -> "бурят"
        | s when s.Contains("забайк") -> "забайк"
        | s when s.Contains("иркут") -> "иркут"
        | s when s.Contains("кемеров") -> "кемеров"
        | s when s.Contains("краснояр") -> "краснояр"
        | s when s.Contains("новосиб") -> "новосиб"
        | s when s.Contains("томск") -> "томск"
        | s when s.Contains("омск") -> "омск"
        | s when s.Contains("тыва") -> "тыва"
        | s when s.Contains("хакас") -> "хакас"
        | s when s.Contains("амурск") -> "амурск"
        | s when s.Contains("еврей") -> "еврей"
        | s when s.Contains("камчат") -> "камчат"
        | s when s.Contains("магад") -> "магад"
        | s when s.Contains("примор") -> "примор"
        | s when s.Contains("сахалин") -> "сахалин"
        | s when s.Contains("якут") -> "саха"
        | s when s.Contains("саха") -> "саха"
        | s when s.Contains("хабар") -> "хабар"
        | s when s.Contains("чукот") -> "чукот"
        | s when s.Contains("крым") -> "крым"
        | s when s.Contains("севастоп") -> "севастоп"
        | s when s.Contains("байкон") -> "байкон"
        | _ -> ""
