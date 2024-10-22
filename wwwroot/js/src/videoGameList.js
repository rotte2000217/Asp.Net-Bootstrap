﻿import { createRoot } from 'react-dom/client';
import React from 'react';
import TableManager from '../components/tableManager.js';

class VideoGameList extends React.Component {
    constructor(props) {
        super(props);
    }

    render() {
        return (
            <div className="small main-content container">
                <h3 className="text-center">{localization.VideoGames}</h3>
                <TableManager
                    url="/VideoGame/Search"
                    typeName={localization.VideoGame}
                    columns={[
                        {
                            title: 'Name',
                            propertyName: 'name'
                        },
                        {
                            title: 'Genre',
                            propertyName: 'genre'
                        },
                        {
                            title: 'Release date',
                            propertyName: 'releaseDate'
                        },
                        {
                            title: 'Developer',
                            propertyName: 'developerName'
                        },
                        {
                            title: 'Publisher',
                            propertyName: 'publisherName'
                        }
                    ]}
                    filters={[
                        {
                            label: 'Name',
                            propertyName: 'name'
                        }
                    ]}
                    rowButtons={[
                        /*{//TODO: Show this then readonly
                            icon: 'fa-solid fa-arrow-up-right-from-square',
                            tooltip: localization.Open,
                            onClick: (videoGame) => { console.log('open'); }
                        },*/
                        {
                            icon: 'fa-solid fa-pen',
                            tooltip: localization.Edit,
                            onClick: (videoGame) => { window.location = baseUrl + '/VideoGame/Form?id=' + videoGame.id; }
                        },
                        {
                            icon: 'fa-solid fa-x',
                            tooltip: localization.Delete,
                            deleteFormUrl: '/VideoGame'
                        }
                    ]}
                    buttons={[
                        {
                            text: localization.New,
                            href: baseUrl + '/VideoGame/Form'
                        }
                    ]}
                />
            </div>
        );
    }
}

createRoot(document.getElementById('root')).render(<VideoGameList />);