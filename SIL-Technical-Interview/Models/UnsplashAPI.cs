public class UnsplashAPI
{
    public string? Id { get; set; }
    public string? Slug { get; set; }
    public URLS? Urls { get; set; }
    public string? Description { get; set; }
    public string? AltDescription { get; set; }
    public string? Raw { get; set; }
    public string? Full { get; set; }
    public string? Regular { get; set; }
    public string? Small { get; set; }
    public string? Thumb { get; set; }
    public string? SmallS3 { get; set; }
}

//URLS class
public class URLS
{
    public string? Raw { get; set; }
    public string? Full { get; set; }
    public string? Regular { get; set; }
    public string? Small { get; set; }
    public string? Thumb { get; set; }
    public string? SmallS3 { get; set; }
}

/*
Photo JSON data

{
        "id": "mjFc946CPXY",
        "slug": "ai-generated-portrait-of-a-model-laying-with-hand-on-head-mjFc946CPXY",
        "alternative_slugs": {
            "en": "ai-generated-portrait-of-a-model-laying-with-hand-on-head-mjFc946CPXY",
            "es": "ai-genero-un-retrato-de-un-modelo-acostado-con-la-mano-en-la-cabeza-mjFc946CPXY",
            "ja": "aiが生成した頭に手を置いたモデルのポートレート-mjFc946CPXY",
            "fr": "portrait-genere-par-lia-dun-modele-allonge-avec-la-main-sur-la-tete-mjFc946CPXY",
            "it": "ritratto-generato-dallintelligenza-artificiale-di-una-modella-sdraiata-con-la-mano-sulla-testa-mjFc946CPXY",
            "ko": "ai는-머리에-손을-얹고-누워있는-모델의-초상화를-생성했습니다-mjFc946CPXY",
            "de": "ki-generiertes-portrat-eines-models-das-mit-der-hand-auf-dem-kopf-liegt-mjFc946CPXY",
            "pt": "ai-gerou-retrato-de-uma-modelo-deitada-com-a-mao-na-cabeca-mjFc946CPXY"
        },
        "created_at": "2024-04-11T14:58:49Z",
        "updated_at": "2024-06-18T12:13:20Z",
        "promoted_at": null,
        "width": 6000,
        "height": 3375,
        "color": "#d9d9d9",
        "blur_hash": "LYHetWWB-;xu~qIURjt7?bM{IUxu",
        "description": "AI Generated Image.",
        "alt_description": "Ai generated portrait of a model laying with hand on head",
        "breadcrumbs": [],
        "urls": {
            "raw": "https://images.unsplash.com/photo-1712847331843-b1118196c447?ixid=M3w2MjM2NDh8MXwxfGFsbHwxfHx8fHx8Mnx8MTcxODcxNDAzOXw&ixlib=rb-4.0.3",
            "full": "https://images.unsplash.com/photo-1712847331843-b1118196c447?crop=entropy&cs=srgb&fm=jpg&ixid=M3w2MjM2NDh8MXwxfGFsbHwxfHx8fHx8Mnx8MTcxODcxNDAzOXw&ixlib=rb-4.0.3&q=85",
            "regular": "https://images.unsplash.com/photo-1712847331843-b1118196c447?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&ixid=M3w2MjM2NDh8MXwxfGFsbHwxfHx8fHx8Mnx8MTcxODcxNDAzOXw&ixlib=rb-4.0.3&q=80&w=1080",
            "small": "https://images.unsplash.com/photo-1712847331843-b1118196c447?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&ixid=M3w2MjM2NDh8MXwxfGFsbHwxfHx8fHx8Mnx8MTcxODcxNDAzOXw&ixlib=rb-4.0.3&q=80&w=400",
            "thumb": "https://images.unsplash.com/photo-1712847331843-b1118196c447?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&ixid=M3w2MjM2NDh8MXwxfGFsbHwxfHx8fHx8Mnx8MTcxODcxNDAzOXw&ixlib=rb-4.0.3&q=80&w=200",
            "small_s3": "https://s3.us-west-2.amazonaws.com/images.unsplash.com/small/photo-1712847331843-b1118196c447"
        },
        "links": {
            "self": "https://api.unsplash.com/photos/ai-generated-portrait-of-a-model-laying-with-hand-on-head-mjFc946CPXY",
            "html": "https://unsplash.com/photos/ai-generated-portrait-of-a-model-laying-with-hand-on-head-mjFc946CPXY",
            "download": "https://unsplash.com/photos/mjFc946CPXY/download?ixid=M3w2MjM2NDh8MXwxfGFsbHwxfHx8fHx8Mnx8MTcxODcxNDAzOXw",
            "download_location": "https://api.unsplash.com/photos/mjFc946CPXY/download?ixid=M3w2MjM2NDh8MXwxfGFsbHwxfHx8fHx8Mnx8MTcxODcxNDAzOXw"
        },
        "likes": 31,
        "liked_by_user": false,
        "current_user_collections": [],
        "sponsorship": {
            "impression_urls": [],
            "tagline": "Born to Mix - AI Generated",
            "tagline_url": "http://www.absolut.com",
            "sponsor": {
                "id": "AjLWUgPA1CA",
                "updated_at": "2024-06-18T07:35:03Z",
                "username": "absolut",
                "name": "ABSOLUT",
                "first_name": "ABSOLUT",
                "last_name": null,
                "twitter_username": null,
                "portfolio_url": "https://www.absolut.com/en/campaign/absolut-intelligence/",
                "bio": "Challenge the stereotypical portrayal of fashion and lifestyle models in AI. We believe in a true human portrait with a more inclusive representation.",
                "location": null,
                "links": {
                    "self": "https://api.unsplash.com/users/absolut",
                    "html": "https://unsplash.com/@absolut",
                    "photos": "https://api.unsplash.com/users/absolut/photos",
                    "likes": "https://api.unsplash.com/users/absolut/likes",
                    "portfolio": "https://api.unsplash.com/users/absolut/portfolio",
                    "following": "https://api.unsplash.com/users/absolut/following",
                    "followers": "https://api.unsplash.com/users/absolut/followers"
                },
                "profile_image": {
                    "small": "https://images.unsplash.com/profile-1712762899768-602cce598ab9image?ixlib=rb-4.0.3&crop=faces&fit=crop&w=32&h=32",
                    "medium": "https://images.unsplash.com/profile-1712762899768-602cce598ab9image?ixlib=rb-4.0.3&crop=faces&fit=crop&w=64&h=64",
                    "large": "https://images.unsplash.com/profile-1712762899768-602cce598ab9image?ixlib=rb-4.0.3&crop=faces&fit=crop&w=128&h=128"
                },
                "instagram_username": "absolutvodka",
                "total_collections": 0,
                "total_likes": 0,
                "total_photos": 19,
                "total_promoted_photos": 0,
                "total_illustrations": 0,
                "total_promoted_illustrations": 0,
                "accepted_tos": true,
                "for_hire": false,
                "social": {
                    "instagram_username": "absolutvodka",
                    "portfolio_url": "https://www.absolut.com/en/campaign/absolut-intelligence/",
                    "twitter_username": null,
                    "paypal_email": null
                }
            }
        },
        "topic_submissions": {},
        "asset_type": "photo",
        "user": {
            "id": "AjLWUgPA1CA",
            "updated_at": "2024-06-18T07:35:03Z",
            "username": "absolut",
            "name": "ABSOLUT",
            "first_name": "ABSOLUT",
            "last_name": null,
            "twitter_username": null,
            "portfolio_url": "https://www.absolut.com/en/campaign/absolut-intelligence/",
            "bio": "Challenge the stereotypical portrayal of fashion and lifestyle models in AI. We believe in a true human portrait with a more inclusive representation.",
            "location": null,
            "links": {
                "self": "https://api.unsplash.com/users/absolut",
                "html": "https://unsplash.com/@absolut",
                "photos": "https://api.unsplash.com/users/absolut/photos",
                "likes": "https://api.unsplash.com/users/absolut/likes",
                "portfolio": "https://api.unsplash.com/users/absolut/portfolio",
                "following": "https://api.unsplash.com/users/absolut/following",
                "followers": "https://api.unsplash.com/users/absolut/followers"
            },
            "profile_image": {
                "small": "https://images.unsplash.com/profile-1712762899768-602cce598ab9image?ixlib=rb-4.0.3&crop=faces&fit=crop&w=32&h=32",
                "medium": "https://images.unsplash.com/profile-1712762899768-602cce598ab9image?ixlib=rb-4.0.3&crop=faces&fit=crop&w=64&h=64",
                "large": "https://images.unsplash.com/profile-1712762899768-602cce598ab9image?ixlib=rb-4.0.3&crop=faces&fit=crop&w=128&h=128"
            },
            "instagram_username": "absolutvodka",
            "total_collections": 0,
            "total_likes": 0,
            "total_photos": 19,
            "total_promoted_photos": 0,
            "total_illustrations": 0,
            "total_promoted_illustrations": 0,
            "accepted_tos": true,
            "for_hire": false,
            "social": {
                "instagram_username": "absolutvodka",
                "portfolio_url": "https://www.absolut.com/en/campaign/absolut-intelligence/",
                "twitter_username": null,
                "paypal_email": null
            }
        }
    }


 */