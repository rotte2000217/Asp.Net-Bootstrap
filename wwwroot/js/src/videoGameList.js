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
                        /*{TODO: Show this then readonly
                            icon: 'fa-solid fa-arrow-up-right-from-square',
                            tooltip: localization.Open,
                            onClick: (videoGame) => { console.log(videoGame); }
                        }*/
                        {
                            icon: 'fa-solid fa-pen',
                            tooltip: localization.Edit,
                            onClick: (videoGame) => { console.log(videoGame); }
                        },
                        {
                            icon: 'fa-solid fa-x',
                            tooltip: localization.Delete,
                            onClick: (videoGame) => { console.log(videoGame); }
                        }
                    ]}
                />
            </div>
        );
    }
}

createRoot(document.getElementById('root')).render(<VideoGameList />);